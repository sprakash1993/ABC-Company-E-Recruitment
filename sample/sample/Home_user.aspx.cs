///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : User Home Page 
// ---------------------------------------------------------------------------------
// Date Created  : 12/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample
{
    public partial class Home_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
                Response.Redirect("Login.aspx");
        }
    }
}