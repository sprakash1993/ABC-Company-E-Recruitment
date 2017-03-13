///////////////////////////////////////////////////////////////////////////////////////////////
//
// File Summary  : Change Password Page 
// ---------------------------------------------------------------------------------
// Date Created  : 06/08/2014
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
    public partial class LoginChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox3.Text.Equals("tcshyd"))
                {
                    string username = Request.QueryString["username"];
                    string password = TextBox2.Text;
                    if (password.Equals(TextBox3.Text))
                    {
                        Label4.Text = "Old password cannot be same as new password";
                    }
                    else
                    {
                        IUsermanager umngr = new UserManagerFactory().CreateUserManager();

                        int row = umngr.ChangePwd(username, password);
                        if (row > 0)
                        {
                            Response.Redirect("Login.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('Password Change Failed')</script>");
                        }
                    }
                }
                else
                    Label4.Text = "Incorrect password";
            }
            catch
            {
                Response.Write("<script>alert('Session Expired please login again');window.location='Home.aspx'</script>");
            }
        }
    }
}