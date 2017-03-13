using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IBGCAdministratorDB
    {
        int AddBGCAdmin(IBGCAdministrator admin);

        int ApproveAdminStatus(int bgcID, int status, DateTime statusTime);
        SortedList<int, IBGCAdministrator> GetAdminList();
        List<int> GetAdminIDList();
        List<int> GetAdminEmpID();
        int GetAdminStatus(int empID);
    }
}
