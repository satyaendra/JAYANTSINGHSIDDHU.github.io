using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using personalDB;

namespace Personal_Blog.JayantAdmin
{
    public partial class list : System.Web.UI.Page
    {
        LoginDataLayer objlyr = new LoginDataLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id"] != null)
                {
                    getlist();
                }
                else
                {
                    Response.Redirect("Adminlogin");
                }
            }
        }
        void getlist()
        {
            grduser.DataSource = objlyr.getregisteruser();
            grduser.DataBind();
        }
    }
}