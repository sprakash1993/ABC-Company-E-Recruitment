///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Edit Employee Page 
// ---------------------------------------------------------------------------------
// Date Created  : 10/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using BLL;
using BLLFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;

namespace sample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IEmployeeManager emplMngr = new EmployeeManagerFactory().CreateEmployeeManager();
        SortedList<int, IEmployee> empList = new SortedList<int, IEmployee>();
        List<IEmployee> emp1 = new List<IEmployee>();
       protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HRID"] == null)
                Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                BindGrdEmployee();
            }
        }

        private void BindGrdEmployee()
        {
            empList = emplMngr.GetEmployeeList();
            foreach (IEmployee value in empList.Values)
                emp1.Add(value);
            grdemp.DataSource = emp1;
            grdemp.DataBind();
            if (grdemp.Rows.Count == 0)
                Label1.Text = "No values to display";
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
            DropDownList txt1 = (DropDownList)row.FindControl("txtdesignation");
            TextBox txt2 = (TextBox)row.FindControl("txtctc");
            int EmployeeId = Convert.ToInt32(lbl1.Text);
            string Designation = txt1.SelectedItem.ToString();
            float CTC = float.Parse(txt2.Text);
            emplMngr.UpdateEmployee(EmployeeId, CTC, Designation);
            grdemp.EditIndex = -1;
            BindGrdEmployee();
        }

        protected void grdemp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdemp.EditIndex = -1;
            BindGrdEmployee();
        }

        protected void grdemp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdemp.PageIndex = e.NewPageIndex;
            BindGrdEmployee();
        }

      
    }
}