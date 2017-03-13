///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Display candidate profile page
// ---------------------------------------------------------------------------------
// Date Created  : 10/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using BOFactory;
using DBFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types;

namespace sample
{
    public partial class CandidateProfileDisplay : System.Web.UI.Page
    {
        ICandidateProfile cp = new CandidateProfileFactory().CreateCandidateProfile();
        SortedList<int, ICandidateProfile> cplist = new SortedList<int, ICandidateProfile>();
        List<ICandidateProfile> cplist1 = new List<ICandidateProfile>();
        ICandidateProfileDB cpDb = new CandidateProfileDBFactory().CreateCandidateProfileDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminID"] == null)
                Response.Redirect("Login.aspx"); 
        }

        private void Binddata1()
        {
            cplist = cpDb.GetCandidateProfileList_VacancyId();
            foreach (ICandidateProfile value in cplist.Values)
                cplist1.Add(value);
            GridView1.DataSource = cplist1;
            GridView1.DataBind();

        }
        private void Binddata2()
        {
            cplist = cpDb.GetCandidateProfileList();
            foreach (ICandidateProfile value in cplist.Values)
                cplist1.Add(value);
            GridView2.DataSource = cplist1;
            GridView2.DataBind();
        }
        private void Binddata3()
        {
            cplist = cpDb.GetCandidateProfileList_TestStatus();
            foreach (ICandidateProfile value in cplist.Values)
                cplist1.Add(value);
            GridView3.DataSource = cplist1;
            GridView3.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedIndex == 0)
            {
                GridView2.Visible = false;
                GridView3.Visible = false;
                GridView1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "Select a valid option";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                GridView2.Visible = false;
                GridView3.Visible = false;
                GridView1.Visible = true;
                Label2.Visible = false;
                Binddata1();
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                GridView1.Visible = false;
                GridView3.Visible = false;
                GridView2.Visible = true;
                Label2.Visible = false;
                Binddata2();

            }
            else
            {
                GridView2.Visible = false;
                GridView1.Visible = false;
                GridView3.Visible = true;
                Label2.Visible = false;
                Binddata3();
            }
        }
    }
}