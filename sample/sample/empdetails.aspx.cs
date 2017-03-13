using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;
using DB;
using DBFactory;
using BO;
using BOFactory;
using BLL;
using BLLFactory;

namespace sample
{
    public partial class empdetails : System.Web.UI.Page
    {
        IEmployee emp = new EmployeeFactory().CreateEmployee();
        SortedList<int, IEmployee> empList = new SortedList<int, IEmployee>();
        List<IEmployee> emp1= new List<IEmployee>();
        IEmployeeDB empDb = new EmployeeDBFactory().CreateEmployeeDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrdEmployee();
            }
        }

        private void BindGrdEmployee()
        {
            empList = empDb.GetEmpList();
            foreach (IEmployee value in empList.Values)
                emp1.Add(value);
            grdemp.DataSource = emp1;
            grdemp.DataBind();
        }
        protected void grdemployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdemp.EditIndex = e.NewEditIndex;
            BindGrdEmployee();

        }

        protected void grdemployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = grdemp.Rows[e.RowIndex];
            Label lbl1 = (Label)row.FindControl("lblemployeeId");
            Label lbl2 = (Label)row.FindControl("lbldob");
            Label lbl3 = (Label)row.FindControl("lbldoj");
            Label lbl4 = (Label)row.FindControl("lblgender");
            Label lbl5 = (Label)row.FindControl("lbldivision");
            Label lbl6 = (Label)row.FindControl("lblprojectid");
            Label lbl7 = (Label)row.FindControl("lblunithead");
            TextBox txt1 = (TextBox)row.FindControl("txtdesignation");
            TextBox txt2 = (TextBox)row.FindControl("txtctc");
            emp.EmployeeId = Convert.ToInt32(lbl1.Text);
            emp.Designation = txt1.Text;
            emp.CTC = float.Parse(txt2.Text);
            emp.DOB = Convert.ToDateTime(lbl2.Text);
            emp.DOJ = Convert.ToDateTime(lbl3.Text);
            emp.Gender = lbl4.Text;
            emp.Division = lbl5.Text;
            emp.ProjectID = Convert.ToInt32(lbl6.Text);
            emp.UnitHeadID =Convert.ToInt32(lbl7.Text);
            empDb.UpdateEmployee(emp.EmployeeId,emp.CTC,emp.Designation);
            grdemp.EditIndex = -1;
            BindGrdEmployee();
        }

        protected void grdemp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdemp.EditIndex = -1;
            BindGrdEmployee();
        }
    }
}