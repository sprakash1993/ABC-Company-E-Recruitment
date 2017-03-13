using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmployeeManager
    {
        SortedList<int, IEmployee> EmployeeList { get; set; }
        int AddEmployee(string empName, DateTime dob, DateTime doj, string gender, string division, float ctc, string designation, int unitHeadId, int projectId, bool isHr, bool isNew);
        IEmployee CreateEmployee();
        SortedList<int, IEmployee> GetEmployeeList();
        void UpdateEmployee(int empID, float ctc, string desigantion);
        List<int> GetEmployeeIDList();
        int CheckHr(int empID);
    }
}
