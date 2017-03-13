using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class Employee : IEmployee
    {
        int employeeID, unitHeadID, projectID;
        string employeeName, gender, division, designation;
        DateTime dob, doj;
        bool isHR, isNew;
        float ctc;

        public int EmployeeId
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public int UnitHeadID
        {
            get { return unitHeadID; }
            set { unitHeadID = value; }
        }
        public int ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Division
        {
            get { return division; }
            set { division = value; }
        }
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public float CTC
        {
            get { return ctc; }
            set { ctc = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public DateTime DOJ
        {
            get { return doj; }
            set { doj = value; }
        }

        public bool IsHR
        {
            get { return isHR; }
            set { isHR = value; }
        }

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }
    }
}
