using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DBFactory
{
    public class BGCScheduleDBFactory
    {
        IBGCScheduleDB sdb = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IBGCScheduleDB CreateBGCScheduleDB()
        {
            if (sdb == null)
            {
                sdb = new BGCScheduleDB();
            }
            return sdb;
        }
    }
}
