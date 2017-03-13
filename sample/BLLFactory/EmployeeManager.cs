using BOFactory;
using DBFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BLLFactory
{
    public class EmployeeManager : IEmployeeManager
    {
        SortedList<int, IEmployee> employees = new SortedList<int, IEmployee>();

        /// <summary>
        /// 
        /// </summary>
        public SortedList<int, IEmployee> EmployeeList
        {
            get { return employees; }
            set { employees = value; }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empName"></param>
        /// <param name="dob"></param>
        /// <param name="doj"></param>
        /// <param name="gender"></param>
        /// <param name="division"></param>
        /// <param name="ctc"></param>
        /// <param name="designation"></param>
        /// <param name="unitHeadId"></param>
        /// <param name="projectId"></param>
        /// <param name="isHr"></param>
        /// <param name="isNew"></param>
        /// <returns></returns>

        public int AddEmployee(string empName, DateTime dob, DateTime doj, string gender, string division, float ctc, string designation, int unitHeadId, int projectId, bool isHr, bool isNew)
        {
            IEmployee emp = new EmployeeFactory().CreateEmployee(empName, dob, doj, gender, division, ctc, designation, unitHeadId, projectId, isHr, isNew);

            IEmployeeDB edb = new EmployeeDBFactory().CreateEmployeeDB();

            return (edb.AddEmployee(emp));

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public SortedList<int, IEmployee> GetEmployeeList()
        {
            IEmployeeDB edb = new EmployeeDBFactory().CreateEmployeeDB();
            return(edb.GetEmpList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEmployee CreateEmployee()
        {
            IEmployee emp = new EmployeeFactory().CreateEmployee();
            return emp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="ctc"></param>
        /// <param name="desigantion"></param>
        public void UpdateEmployee(int empID, float ctc, string desigantion)
        {
            IEmployeeDB edb = new EmployeeDBFactory().CreateEmployeeDB();
            edb.UpdateEmployee(empID,ctc,desigantion);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<int> GetEmployeeIDList()
        {
            IEmployeeDB edb = new EmployeeDBFactory().CreateEmployeeDB();
            return(edb.GetEmployeeIDList());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empID"></param>
        /// <returns></returns>
        public int CheckHr(int empID)
        {
            IEmployeeDB edb = new EmployeeDBFactory().CreateEmployeeDB();
            return (edb.CheckHr(empID));
        }
    }
}
