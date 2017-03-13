using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BOFactory
{
    public class EmployeeFactory
    {
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
        public IEmployee CreateEmployee(string empName, DateTime dob, DateTime doj, string gender, string division, float ctc, string designation, int unitHeadId, int projectId, bool isHr, bool isNew)
        {
            IEmployee employee = new Employee();
            //employee.EmployeeId = empId;
            employee.EmployeeName = empName;
            employee.DOB = dob;
            employee.DOJ = doj;
            employee.Gender = gender;
            employee.Division = division;
            employee.Designation = designation;
            employee.CTC = ctc;
            employee.UnitHeadID = unitHeadId;
            employee.ProjectID = projectId;
            employee.IsHR = isHr;
            employee.IsNew = isNew;

            return employee;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="empId"></param>
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

        public IEmployee CreateEmployee(int empId,string empName, DateTime dob, DateTime doj, string gender, string division, float ctc, string designation, int unitHeadId, int projectId, bool isHr, bool isNew)
        {
            IEmployee employee = new Employee();
            employee.EmployeeId = empId;
            employee.EmployeeName = empName;
            employee.DOB = dob;
            employee.DOJ = doj;
            employee.Gender = gender;
            employee.Division = division;
            employee.Designation = designation;
            employee.CTC = ctc;
            employee.UnitHeadID = unitHeadId;
            employee.ProjectID = projectId;
            employee.IsHR = isHr;
            employee.IsNew = isNew;

            return employee;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEmployee CreateEmployee()
        {
            IEmployee employee = new Employee();
            return employee;

        }
    }
}
