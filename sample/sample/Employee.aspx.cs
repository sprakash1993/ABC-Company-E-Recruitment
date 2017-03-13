///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Add Employee Page 
// ---------------------------------------------------------------------------------
// Date Created  : 10/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;

namespace sample
{
    public partial class Employee1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HRID"] == null)
                Response.Redirect("Login.aspx");
            RangeValidator2.Type = ValidationDataType.Date;
            RangeValidator2.MaximumValue = DateTime.Now.AddMonths(3).ToShortDateString();
            RangeValidator2.MinimumValue = DateTime.Now.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string empName = TextBox1.Text;
            DateTime dob = Convert.ToDateTime(TextBox2.Text);
            string division = TextBox3.SelectedItem.ToString();
            DateTime doj = Convert.ToDateTime(TextBox7.Text);
            string gender = RadioButtonList1.SelectedValue;
            float ctc = float.Parse(TextBox5.Text);
            string designation = TextBox6.SelectedItem.ToString();
            int unitheadId = Convert.ToInt32( DropDownList1.SelectedValue);
            int projectId = Convert.ToInt32(DropDownList2.SelectedValue);
            bool ishr = false;
            bool isnew = true;

            IEmployeeManager empMngr = new EmployeeManagerFactory().CreateEmployeeManager() ;

            int row = empMngr.AddEmployee(empName, dob, doj, gender, division, ctc, designation, unitheadId, projectId, ishr, isnew);
            if (row > 0)
            {
                IUsermanager umngr = new UserManagerFactory().CreateUserManager();
                umngr.AddUser(row.ToString(), "tcshyd", Convert.ToInt32(isnew));
                Response.Write("<script>alert('Added successfully - EmpID : " + row + "');window.location='Home_HR.aspx'</script>");
            }
            else
                Response.Write("<script>alert('Failed')</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home_HR.aspx");
        }
    }
}