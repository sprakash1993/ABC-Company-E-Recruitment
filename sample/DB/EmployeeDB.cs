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
    public class EmployeeDB : IEmployeeDB
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         public SortedList<int, IEmployee> GetEmpList()
        {
             
             SortedList<int, IEmployee> employees=new SortedList<int,IEmployee>();
              SqlConnection connection = DBUtility.getConnection();
              connection.Open();
              SqlCommand command = new SqlCommand();
              command.CommandType = CommandType.StoredProcedure;
              command.CommandText = "sp_displayEmp";
              command.Connection = connection;


              SqlDataReader reader = command.ExecuteReader();
              while (reader.Read())
              {
                  string empname = (string)reader["EmployeeName"];
                  int empId = Convert.ToInt32(reader["EmployeeID"]);
                  DateTime dob = Convert.ToDateTime(reader["DOB"]);
                  DateTime doj = Convert.ToDateTime(reader["DOJ"]);
                  string gender = (string)reader["Gender"];
                  string divison = (string)reader["Division"];
                  float ctc = Convert.ToInt32(reader["CTC"]);
                  string designation = (string)reader["Designation"];
                  int unitheadid = Convert.ToInt32(reader["UnitHeadID"]);
                  int projectid = Convert.ToInt32(reader["ProjectID"]);
                  bool ishr = Convert.ToBoolean(reader["IsHR"]);
                  bool isnew = Convert.ToBoolean(reader["IsNew"]);

                  IEmployee emp = new EmployeeFactory().CreateEmployee(empId,empname,dob,doj,gender,divison,ctc,designation,unitheadid,projectid,ishr,isnew);
                  employees.Add(emp.EmployeeId,emp);
                  

             }

              connection.Close();

              return employees;
             
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
         public int AddEmployee(IEmployee emp )
         {
             SqlConnection connection = DBUtility.getConnection();
             connection.Open();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "sp_AddEmployee";
             
             command.Parameters.AddWithValue("@EmployeeName", emp.EmployeeName);
             command.Parameters.AddWithValue("@DOB", emp.DOB);
             command.Parameters.AddWithValue("@DOJ", emp.DOJ);
             command.Parameters.AddWithValue("@Designation", emp.Designation);
             command.Parameters.AddWithValue("@UnitHeadID", emp.UnitHeadID);
             command.Parameters.AddWithValue("@ProjectID", emp.ProjectID);
             command.Parameters.AddWithValue("@Gender", emp.Gender);
             command.Parameters.AddWithValue("@Division", emp.Division);
             command.Parameters.AddWithValue("@IsNew", emp.IsNew);
             command.Parameters.AddWithValue("@IsHR", emp.IsHR);
             command.Parameters.AddWithValue("@CTC", emp.CTC);
             command.Parameters.AddWithValue("@EmployeeID", 0);

             command.Parameters["@EmployeeID"].Direction = ParameterDirection.Output;
             command.Connection = connection;

             int row = command.ExecuteNonQuery();
             connection.Close();
             if (row > 0)
             {
                   return Convert.ToInt32(command.Parameters["@EmployeeID"].Value);
                 
             }
             else
                 return row;

         }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="ctc"></param>
        /// <param name="desigantion"></param>
        /// <returns></returns>
         public int UpdateEmployee(int empID, float ctc, string desigantion)
         {
             SqlConnection connection = DBUtility.getConnection();
             connection.Open();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "sp_UpdateEmployee1";
             command.Parameters.AddWithValue("@EmployeeID", empID);
             command.Parameters.AddWithValue("@CTC", ctc);
             command.Parameters.AddWithValue("@Designation", desigantion);
             command.Connection = connection;
             int row = command.ExecuteNonQuery();
             connection.Close();
             return row;

         }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empID"></param>
        /// <returns></returns>
         public int CheckHr(int empID)
         {
             SqlConnection connection = DBUtility.getConnection();
             connection.Open();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "sp_displayEmp";
             
             command.Connection = connection;

             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                 if (Convert.ToInt32(reader["EmployeeID"]) == empID)
                 {
                     return Convert.ToInt32(reader["IsHR"]);
                 }
             }
             connection.Close();
             return 0;
             
         }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         public List<int> GetEmployeeIDList()
         {
             SqlConnection connection = DBUtility.getConnection();
              connection.Open();
              SqlCommand command = new SqlCommand();
              command.CommandType = CommandType.StoredProcedure;
              command.CommandText = "sp_displayEmp";
              command.Connection = connection;
              List<int> empIDList = new List<int>();

              SqlDataReader reader = command.ExecuteReader();
              while (reader.Read())
              {
                  int empId = Convert.ToInt32(reader["EmployeeID"]);
                  empIDList.Add(empId);
              }
              connection.Close();
              return empIDList;
         }
    }
}
