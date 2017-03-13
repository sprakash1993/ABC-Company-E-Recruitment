///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Login page 
// ---------------------------------------------------------------------------------
// Date Created  : 06/08/2014
// Author   : Group 3, Tata Consultancy Services
//
///////////////////////////////////////////////////////////////////////////////////////////////
using BLL;
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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["unitHeadID"] = null;
            Session["adminID"] = null;
            Session["HRID"] = null;
            Session["userID"] = null;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            IUsermanager umngr = new UserManagerFactory().CreateUserManager();
            int flag = umngr.CheckUser(username, password);

            IBGCAdministratorManager bmngr = new BGCAdministratorManagerFactory().CreateBGCAdministratorManager();
            List<int> adminEmpIDList = bmngr.GetAdminEmpID();

            if (flag.Equals( -1))
            {
                Label1.Text = "Invalid Login Credentials";
            }
            else if (flag.Equals(1))
            {
                Label1.Text = "New User";
                Response.Redirect("LoginChange.aspx?username=" +TextBox1.Text);
            }
            else if (flag.Equals(0))
            {
                IEmployeeManager empMngr = new EmployeeManagerFactory().CreateEmployeeManager();
                if(username.StartsWith("uh"))
                {
                    Session["unitHeadID"] = username;
                    Response.Redirect("Home_unitHead.aspx");
                }
                else if (username.StartsWith("ba"))
                {
                    Session["adminID"] = username;
                    Response.Redirect("Home_admin.aspx");
                }
                else if (empMngr.CheckHr(Convert.ToInt32(username)).Equals(1))
                {
                    Session["HRID"] = username;

                    Response.Redirect("Home_HR.aspx");
                }
                else
                {
                    if (adminEmpIDList.Contains(Convert.ToInt32(username)))
                    {
                        if (bmngr.GetAdminStatus(Convert.ToInt32(username)).Equals(1))
                        {
                            Session["adminID"] = username;
                            Response.Redirect("Home_admin.aspx");
                        }
                    }
                   
                    
                        Session["userID"] = username;
                        Response.Redirect("Home_user.aspx");
                    
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}