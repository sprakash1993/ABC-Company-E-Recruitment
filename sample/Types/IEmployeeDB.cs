using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeDB
    {
        SortedList<int, IEmployee> GetEmpList();
        int AddEmployee(IEmployee emp);
        int UpdateEmployee(int empID, float ctc, string desigantion);
        List<int> GetEmployeeIDList();
        int CheckHr(int empID);
    }
}
