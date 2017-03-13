///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Add BGC Admin page
// ---------------------------------------------------------------------------------
// Date Created  : 13/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using BOFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;

using BLL;

namespace sample
{
    public partial class BGCAdmin : System.Web.UI.Page
    {
        List<int> empIDList = new List<int>();
        List<int> adminEmpList = new List<int>();
        IBGCAdministratorManager adnMngr = new BGCAdministratorManagerFactory().CreateBGCAdministratorManager();
        IEmployeeManager empMngr = new EmployeeManagerFactory().CreateEmployeeManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["HRID"] == null)
                    Response.Redirect("Login.aspx");
                BindEmployeedropdown();
            }
        }

        protected void BindEmployeedropdown()
        {
            adminEmpList = adnMngr.GetAdminEmpID();
            empIDList=empMngr.GetEmployeeIDList();
            foreach (int employeeId in adminEmpList)
            {
                if(empIDList.Contains(employeeId))
                {
                    empIDList.Remove(employeeId);
                }
            }
 
            DropDownList1.DataSource = empIDList;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int empID = Convert.ToInt32(DropDownList1.SelectedValue);
                int status = 0;
                DateTime statusTime = DateTime.Now;
                int row = adnMngr.AddBGCAdmin(status, statusTime, empID);

                if (row > 0)
                    Response.Write("<script>alert('Added successfully - AdminID : " + row + "');window.location='Home_HR.aspx'</script>");

                else
                    Response.Write("<script>alert('Failed')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ ex.Message+"')</script>");

            }

        }
    }
}