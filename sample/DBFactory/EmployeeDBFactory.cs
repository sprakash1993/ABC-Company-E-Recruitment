using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;


namespace DBFactory
{
    public class EmployeeDBFactory
    {
        IEmployeeDB empdb = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEmployeeDB CreateEmployeeDB()
        {
            if (empdb == null)
            {
                empdb = new EmployeeDB();
            }
            return empdb;
        }
    }
}
