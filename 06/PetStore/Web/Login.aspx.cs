using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Web
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            int UserId = 0;
            string constr = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("LoginUser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", txt_UserName.Text);
            cmd.Parameters.AddWithValue("@Password", txt_Password.Text);
            cmd.Connection = con;
            con.Open();
            UserId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            switch (UserId)
            {
                case -1:
                    lbl_error.Text = "Username and/or Password is incorrect.";
                    break;
                default:
                    Session["UserName"] = txt_UserName.Text + UserId.ToString();
                    Response.Redirect("Default.aspx");
                    break;
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}