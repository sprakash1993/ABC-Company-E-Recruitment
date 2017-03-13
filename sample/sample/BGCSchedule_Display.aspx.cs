///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : BGC test schedule display page
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
    public partial class BGCSchedule_Display : System.Web.UI.Page
    {
        IBGCScheduleManager schMngr = new BGCScheduleManagerFactory().CreateBGCScheduleManager();
        SortedList<int, IBGCTestSchedule> schList = new SortedList<int, IBGCTestSchedule>();
        List<IBGCTestSchedule> sch1 = new List<IBGCTestSchedule>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HRID"] == null)
                Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                
                BindGrdSchedule();
            }
        }

        private void BindGrdSchedule()
        {
            schList = schMngr.GetScheduleList();
            foreach (IBGCTestSchedule value in schList.Values)
                sch1.Add(value);
            grdschedule.DataSource = sch1;
            grdschedule.DataBind();
            if (grdschedule.Rows.Count==0)
                Label1.Text = "NO values to display";
        }

        protected void grdschedule_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdschedule.PageIndex = e.NewPageIndex;
            BindGrdSchedule();
        }
     }
    
}