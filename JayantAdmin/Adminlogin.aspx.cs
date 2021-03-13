using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using personalDB;

namespace Personal_Blog.JayantAdmin
{
    public partial class Adminlogin : System.Web.UI.Page
    {
        Connection con = new Connection();
        LoginDataLayer objlyr = new LoginDataLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Login()
        {
            try
            {
                var q = objlyr.GetAdminLogin(txtemail.Value,txtPassword.Value);
                if (q.Any())
                {
                    foreach (AdminLogin k in q)
                    {
                        Session["mail"] = k.Email;
                        Session["contact"] = k.Phone;
                        Session["id"] = k.Id;
                        Session["password"] = k.Passwrd;
                    
                    }

                    Response.Redirect("list");
                }
                else
                {
                    lblmsg.Text = "Invalid UserId/Password";
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void btnsub_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}