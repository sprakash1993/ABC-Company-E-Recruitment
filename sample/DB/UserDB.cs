using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;
using BOFactory;


namespace DB
{
    public class UserDB : IUserDB
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SortedList<string, IUser> GetList()
        {
            SortedList<string, IUser> users = new SortedList<string, IUser>();

             SqlConnection connection = DBUtility.getConnection();
             connection.Open();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.StoredProcedure;
             command.CommandText = "sp_getUsers";
             command.Connection = connection;
             
             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
             {
                 string username = (string)reader["Username"];
                 string password = (string)reader["pasword"];
                 int status = Convert.ToInt32(reader["stat"]);

                 IUser newUser = new UserFactory().CreateUser(username, password, status);
                 users.Add(newUser.UserName,newUser);

             }

             connection.Close();

             return users;


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <param name="userList"></param>
        /// <returns></returns>
        public int CheckUser(string uname, string pass,SortedList<string, IUser> userList)
        {
            foreach(IUser value in userList.Values)
            {
                if (uname == value.UserName && pass == value.Password)
                {
                    return value.Status;
                }

            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int ChangePwd(string username, string password)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_changePwd";
            command.Connection = connection;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@pasword", password);
            command.Parameters.AddWithValue("@stat", 0);

            int row = command.ExecuteNonQuery();
            connection.Close();
            return row;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int AddUser(string userName, string password, int status)
        {
            SqlConnection connection = DBUtility.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_LoginInsert1";
            command.Connection = connection;
            command.Parameters.AddWithValue("@Username", userName);
            command.Parameters.AddWithValue("@pasword", password);
            command.Parameters.AddWithValue("@stat", status);
            int row = command.ExecuteNonQuery();
            connection.Close();
            return row;
        }
        
    }
}
