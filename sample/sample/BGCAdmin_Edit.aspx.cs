///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : BGC Admin Edit page
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
    public partial class BGCAdmin_Edit : System.Web.UI.Page
    {
        IBGCAdministratorManager admMngr = new BGCAdministratorManagerFactory().CreateBGCAdministratorManager();

        SortedList<int, IBGCAdministrator> admList = new SortedList<int, IBGCAdministrator>();
        List<IBGCAdministrator> adm1 = new List<IBGCAdministrator>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["unitHeadID"] == null)
                Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                BindGrdAdmin();
            }
        }

        private void BindGrdAdmin()
        {
            admList = admMngr.GetAdminList();
            foreach (IBGCAdministrator value in admList.Values)
                adm1.Add(value);
            grdadmin.DataSource = adm1;
            grdadmin.DataBind();
            if (grdadmin.Rows.Count == 0)
                Label1.Text = "NO values to display";
        }

        protected void grdBGCAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdadmin.EditIndex = e.NewEditIndex;
            BindGrdAdmin();
        }


        protected void grdBGCAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = grdadmin.Rows[e.RowIndex];
            Label lbl1 = (Label)row.FindControl("lblAdminId");
            Label lbl2 = (Label)row.FindControl("lblStatus");
            Label lbl3 = (Label)row.FindControl("lblStatusTime");

            TextBox txt1 = (TextBox)row.FindControl("txtStatus");
            DropDownList dl1 = (DropDownList)row.FindControl("DropDownList1");
          
            int adminID = Convert.ToInt32(lbl1.Text);
            int status = dl1.SelectedIndex;
            DateTime statusTime = DateTime.Now;



            admMngr.ApproveAdminStatus(adminID, status, statusTime);
            grdadmin.EditIndex = -1;
            BindGrdAdmin();

        }

        protected void grdBGCAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdadmin.EditIndex = -1;
            BindGrdAdmin();
        }

       

        protected void grdadmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdadmin.PageIndex = e.NewPageIndex;
            BindGrdAdmin();
        }
            
    }
}