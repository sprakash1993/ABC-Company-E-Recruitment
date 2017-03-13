
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using BOFactory;
using DBFactory;

namespace BLLFactory
{
    public class BGCAdministratorManager:IBGCAdministratorManager
    {
        SortedList<int, IBGCAdministrator> BGCadmins = new SortedList<int, IBGCAdministrator>();
       
        public SortedList<int, IBGCAdministrator> BGCAdminList
        {
            get { return BGCadmins ; }
            set { BGCadmins = value; }

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="statuschangetime"></param>
        /// <param name="employeeid"></param>
        /// <returns></returns>
        public int AddBGCAdmin(int status, DateTime statuschangetime, int employeeid)
        {
            IBGCAdministrator bgcadmin = new BGCAdministratorFactory().CreateBGCAdminstrator(status, statuschangetime);
            bgcadmin.EmployeeId = employeeid;

            IBGCAdministratorDB adminDb = new BGCAdministratorDBFactory().CreateAdminDB();

            int row = adminDb.AddBGCAdmin(bgcadmin);


            return row;
        }
       
        /// Function Name  : GetAdminList
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public SortedList<int, IBGCAdministrator> GetAdminList()
        {
            IBGCAdministratorDB adminDb = new BGCAdministratorDBFactory().CreateAdminDB();
            return(adminDb.GetAdminList());
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="bgcID"></param>
        /// <param name="status"></param>
        /// <param name="statusTime"></param>
        /// <returns></returns>
        public int ApproveAdminStatus(int bgcID, int status, DateTime statusTime)
        {
            IBGCAdministratorDB adminDb = new BGCAdministratorDBFactory().CreateAdminDB();
            return(adminDb.ApproveAdminStatus(bgcID, status, statusTime));
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetAdminIDList()
        {
            IBGCAdministratorDB adb = new BGCAdministratorDBFactory().CreateAdminDB();
            return (adb.GetAdminIDList());
        }

        public List<int> GetAdminEmpID()
        {
            IBGCAdministratorDB adb = new BGCAdministratorDBFactory().CreateAdminDB();
            return (adb.GetAdminEmpID());
        }

        public int GetAdminStatus(int empID)
        {
            IBGCAdministratorDB adb = new BGCAdministratorDBFactory().CreateAdminDB();
            return (adb.GetAdminStatus(empID));
        }
    }
}
