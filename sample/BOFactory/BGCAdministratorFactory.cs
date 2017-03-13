using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BO;

namespace BOFactory
{
    public class BGCAdministratorFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="administratorid"></param>
        /// <param name="status"></param>
        /// <param name="statuschangetime"></param>
        /// <returns></returns>
        public IBGCAdministrator CreateBGCAdminstrator(int administratorid, int status, DateTime statuschangetime)
        {
            IBGCAdministrator bgcadmin = new BGCAdministrator();
            bgcadmin.AdministratorID = administratorid;
            bgcadmin.Status = status;
            bgcadmin.StatusChangeTime = statuschangetime;
             return bgcadmin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statuschangetime"></param>
        /// <returns></returns>
        public IBGCAdministrator CreateBGCAdminstrator(int status, DateTime statuschangetime)
        {
            IBGCAdministrator bgcadmin = new BGCAdministrator();
            
            bgcadmin.Status = status;
            bgcadmin.StatusChangeTime = statuschangetime;
      
            return bgcadmin;
        }


    }
}
