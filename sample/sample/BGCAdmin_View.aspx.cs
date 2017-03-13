///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : BGC Admin view page
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
    public partial class BGCAdmin_View : System.Web.UI.Page
    {
        IBGCAdministratorManager admMngr = new BGCAdministratorManagerFactory().CreateBGCAdministratorManager();
        SortedList<int, IBGCAdministrator> admList = new SortedList<int, IBGCAdministrator>();
        List<IBGCAdministrator> adm1 = new List<IBGCAdministrator>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HRID"] == null)
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

        protected void grdadmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdadmin.PageIndex = e.NewPageIndex;
            BindGrdAdmin();
        }
     }
}