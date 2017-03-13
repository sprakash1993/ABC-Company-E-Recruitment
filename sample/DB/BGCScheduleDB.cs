using BOFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DB
{
    public class BGCScheduleDB : IBGCScheduleDB
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="schedule"></param>
        /// <returns></returns>
        public int AddBGCSchedule(IBGCTestSchedule schedule)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_AddBGCSchedule";

            command.Parameters.AddWithValue("@fromDate", schedule.FromDate);
            command.Parameters.AddWithValue("@toDate",schedule.ToDate);
            command.Parameters.AddWithValue("@AdministratorId", schedule.AdministratorId);
            command.Parameters.AddWithValue("@BGCID", 0);
            command.Parameters["@BGCID"].Direction = ParameterDirection.Output;
            command.Connection = connection;
            int row = command.ExecuteNonQuery();
            connection.Close();
            if (row > 0)
            {
                return Convert.ToInt32(command.Parameters["@BGCID"].Value);
            }
            else
                return row;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, IBGCTestSchedule> GetScheduleList()
        {
            SortedList<int, IBGCTestSchedule> schedules = new SortedList<int, IBGCTestSchedule>();
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_displaySchedule";
            command.Connection = connection;


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int bgcId = Convert.ToInt32(reader["BGCID"]);
                DateTime fromDate = Convert.ToDateTime(reader["fromDate"]);
                DateTime toDate = Convert.ToDateTime(reader["toDate"]);
                int adminID = Convert.ToInt32(reader["AdministratorId"]);

                IBGCTestSchedule sch = new BGCTestScheduleFactory().CreateSchedule(fromDate, toDate,adminID);
                sch.BGCId = bgcId;
                schedules.Add(sch.BGCId,sch);
            }

            connection.Close();

            return schedules;
        }
    }
}
