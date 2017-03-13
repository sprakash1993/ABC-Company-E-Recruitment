using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DBFactory
{
    public class BGCAdministratorDBFactory
    {
        IBGCAdministratorDB admindb = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IBGCAdministratorDB CreateAdminDB()
        {
            if (admindb == null)
            {
                admindb = new BGCAdministratorDB();
            }
            return admindb;
        }
    }
}
