///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : BGC test schedule page
// ---------------------------------------------------------------------------------
// Date Created  : 13/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////

using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;

namespace sample
{
    public partial class BGCTestSchedule : System.Web.UI.Page
    {
        List<int> admIDList = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HRID"] == null)
                Response.Redirect("Login.aspx");//("10/26/2014");
            RangeValidator1.Type = ValidationDataType.Date;
            RangeValidator1.MaximumValue = DateTime.Now.AddMonths(1).ToShortDateString();
            RangeValidator1.MinimumValue = DateTime.Now.ToShortDateString();
            RangeValidator2.Type = ValidationDataType.Date;
            RangeValidator2.MaximumValue = DateTime.Now.AddMonths(2).ToShortDateString();
            RangeValidator2.MinimumValue = DateTime.Now.ToShortDateString();
        }

        protected void BindAdmindropdown()
        {
            IBGCAdministratorManager admMngr = new BGCAdministratorManagerFactory().CreateBGCAdministratorManager();
            admIDList = admMngr.GetAdminIDList();
            DropDownList1.DataSource = admIDList;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int administratorId = Convert.ToInt32(DropDownList1.SelectedValue);
            DateTime fromDate = Convert.ToDateTime(TextBox1.Text);
            DateTime toDate = Convert.ToDateTime(TextBox2.Text);
            IBGCScheduleManager schMngr = new BGCScheduleManagerFactory().CreateBGCScheduleManager();
            int row = schMngr.AddBGCSchedule(fromDate, toDate, administratorId);
            if (row > 0)
            {
                Response.Write("<script>alert('Added successfully - BGCID : " + row + "');window.location='Home_HR.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed')</script>");
            }
        }

       

       
    }
}