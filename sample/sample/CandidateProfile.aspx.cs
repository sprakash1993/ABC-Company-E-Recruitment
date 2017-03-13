///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Edit Candidate profile page
// ---------------------------------------------------------------------------------
// Date Created  : 10/08/2014
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
    public partial class CandidateProfile : System.Web.UI.Page
    {
        ICandidateProfileManager cpmgr1 = new CandidateProfileManagerFactory().CreateCandidateProfileManager();
        SortedList<int, ICandidateProfile> cplist = new SortedList<int, ICandidateProfile>();
        List<ICandidateProfile> cplist1 = new List<ICandidateProfile>();
       protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminID"] == null)
                Response.Redirect("Login.aspx"); 
            if (!IsPostBack)
            {
                BindData();
            }

        }
        private void BindData()
        {
            cplist = cpmgr1.GetCandidateProfileList();
            foreach (ICandidateProfile value in cplist.Values)
                cplist1.Add(value);
            GridView1.DataSource = cplist1;
            GridView1.DataBind();
            if (GridView1.Rows.Count == 0)
                Label1.Text = "NO values to display";
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int teststatus = 6;
            GridViewRow row = GridView1.Rows[e.RowIndex];
            Label lbl1 = (Label)row.FindControl("candidateId");
            Label lbl2 = (Label)row.FindControl("hrinterviewstatus");
            DropDownList ddl = (DropDownList)row.FindControl("DropDownList1");
            int candidateprofileId = Convert.ToInt32(lbl1.Text);
            bool bgctests = Convert.ToBoolean(ddl.SelectedValue);
            cpmgr1.UpdateCandidateProfile(candidateprofileId, bgctests);
            if (bgctests == true)
            {
                cpmgr1.UpdateCandidateProfile1(candidateprofileId, teststatus);
            }
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
    }
}