using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DB
{
    public class DBUtility
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection getConnection()
        {

            SqlConnection dbConnection = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["connectionString"];

            if (settings != null)
            {
                string connstring = settings.ConnectionString;
                dbConnection = new SqlConnection(connstring);

            }

            return dbConnection;

        }
    }
}
