using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class CustomerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Signup_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string email = tb_Email.Text;
            string zip = tb_Zip.Text;
            string username = tb_UserName.Text;
            string password = tb_Password.Text;

            string ConString = ConfigurationManager.ConnectionStrings["Customerdb"].ConnectionString; //constring =your constring
            
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                using (SqlCommand cmd = new SqlCommand("InsertCustomer"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Zipcode", zip);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Connection = connection;
                    connection.Open();
                    int rows =cmd.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand cmd = new SqlCommand("InsertLogin"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Connection = connection;
                    connection.Open();
                    int row =cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }






        }
    }
}