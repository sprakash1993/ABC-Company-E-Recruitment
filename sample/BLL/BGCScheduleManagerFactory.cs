using BLLFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BLL
{
    public class BGCScheduleManagerFactory
    {
        IBGCScheduleManager bgcMngr = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IBGCScheduleManager CreateBGCScheduleManager()
        {
            if (bgcMngr == null)
            {
                bgcMngr = new BGCScheduleManager();
            }

            return bgcMngr;
        }

    }
}
