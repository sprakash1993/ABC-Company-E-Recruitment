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
    public class BGCAdministratorDB :IBGCAdministratorDB
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int AddBGCAdmin(IBGCAdministrator admin)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_addAdmin";

            command.Parameters.AddWithValue("@AdminStatus", admin.Status );
            command.Parameters.AddWithValue("@EmployeeID", admin.EmployeeId);
            command.Parameters.AddWithValue("@StatusChangeTime", admin.StatusChangeTime);
            command.Parameters.AddWithValue("@AdministratorID", 0);

            command.Parameters["@AdministratorID"].Direction = ParameterDirection.Output;

            command.Connection = connection;

            int row = command.ExecuteNonQuery();
            connection.Close();
            if (row > 0)
            {

                return Convert.ToInt32(command.Parameters["@AdministratorID"].Value);

            }
            else
                return row;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bgcID"></param>
        /// <param name="status"></param>
        /// <param name="statusTime"></param>
        /// <returns></returns>

        public int ApproveAdminStatus(int bgcID,int status,DateTime statusTime)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_approveAdmin";
            command.Parameters.AddWithValue("@AdministratorID", bgcID);
            command.Parameters.AddWithValue("@AdminStatus", status);
            command.Parameters.AddWithValue("@StatusChangeTime", statusTime);
            command.Connection = connection;

            int row = command.ExecuteNonQuery();
            connection.Close();

            return row;   

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<int, IBGCAdministrator> GetAdminList()
        {
            SortedList<int, IBGCAdministrator> admins = new SortedList<int, IBGCAdministrator>();
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_displayAdmin";
            command.Connection = connection;


            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                int empId = Convert.ToInt32(reader["EmployeeID"]);
                DateTime statusTime = Convert.ToDateTime(reader["StatusChangeTime"]);


                int adminID = Convert.ToInt32(reader["AdministratorID"]);
                int status = Convert.ToInt32(reader["AdminStatus"]);


                IBGCAdministrator adm = new BGCAdministratorFactory().CreateBGCAdminstrator(adminID, status, statusTime);
                adm.EmployeeId = empId;
                admins.Add(adm.AdministratorID, adm);
            }

            connection.Close();

            return admins;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetAdminIDList()
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_displayAdmin";
            command.Connection = connection;
            List<int> admIDList = new List<int>();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int adminID = Convert.ToInt32(reader["AdministratorID"]);
                admIDList.Add(adminID);
            }
            connection.Close();
            return admIDList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetAdminEmpID()
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_displayAdmin";
            command.Connection = connection;
            List<int> empIDList = new List<int>();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int empID = Convert.ToInt32(reader["EmployeeID"]);
                empIDList.Add(empID);
            }
            connection.Close();
            return empIDList;
        }

        public int GetAdminStatus(int empID)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_getAdminStatus";
            command.Parameters.AddWithValue("@EmployeeID", empID);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            int status=0;
            while (reader.Read())
            {
                status = Convert.ToInt32(reader["AdminStatus"]);
                
            }
            connection.Close();
            return status;
        }
    }
}
