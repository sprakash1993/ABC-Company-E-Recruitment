using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCAdministratorManager
    {
        SortedList<int, IBGCAdministrator> BGCAdminList { get; set; }
        int AddBGCAdmin( int status, DateTime statuschangetime, int employeeid);
        SortedList<int, IBGCAdministrator> GetAdminList();
        int ApproveAdminStatus(int bgcID, int status, DateTime statusTime);
        List<int> GetAdminIDList();
        List<int> GetAdminEmpID();
        int GetAdminStatus(int empID);
    }
}
