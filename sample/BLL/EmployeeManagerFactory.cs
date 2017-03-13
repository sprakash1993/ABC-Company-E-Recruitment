using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Types;
using BLLFactory;

namespace BLL
{
    public class EmployeeManagerFactory
    {
        IEmployeeManager empmngr = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEmployeeManager CreateEmployeeManager()
        {
            if (empmngr == null)
            {
                empmngr = new EmployeeManager();
            }

            return empmngr;
        }
    }
}
