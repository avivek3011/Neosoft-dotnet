using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                lbl_txt.Text = Session["UserName"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}