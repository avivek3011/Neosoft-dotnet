using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Cat : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
            if (!this.IsPostBack)
            {
                string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
                //Load_dd_CatType(Constring);
                //Load_dd_FurType(Constring);
            }
        }

        private void LoadBindGridView(string constring)
        {
            string catQuery = "select id, Name,Dob, GenderId, catType, FurType from Cats";
            using (SqlConnection cons = new SqlConnection(constring))
            {
                using (SqlDataAdapter ads = new SqlDataAdapter(catQuery, constring))
                {
                    using (DataSet ds = new DataSet())
                    {
                        ads.Fill(ds,"Cats");
                        ds.Tables["Cats"].PrimaryKey = new DataColumn[] { ds.Tables["Cats"].Columns["Id"] };
                        Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                        gv_cats.DataSource = ds;
                        gv_cats.DataBind();
                    }
                }
            }
        }

        private void LoadDataFromCache()
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                gv_cats.DataSource = ds;
                gv_cats.DataBind();
            }
        }
        private void Load_dd_CatType(string Constring)
        {
            string query = "select * from catType";
            using(SqlConnection cons = new SqlConnection(Constring))
            {
                using(SqlDataAdapter ads = new SqlDataAdapter(query, Constring))
                {
                    using (DataTable dt = new DataTable())
                    {
                        ads.Fill(dt);
                        dd_CatType.DataSource = dt;
                        dd_CatType.DataBind();
                        dd_CatType.DataTextField = "Name";
                        dd_CatType.DataValueField = "Id";
                        dd_CatType.DataBind();
                        dd_CatType.Items.Insert(0, new ListItem("Select Cat Type"));
                    }
                }
            }
        }
        private void Load_dd_FurType(string Constring)
        {
            string query = "select * from FurType";
            using (SqlConnection cons = new SqlConnection(Constring))
            {
                using (SqlDataAdapter ads = new SqlDataAdapter(query, Constring))
                {
                    using (DataTable dt = new DataTable())
                    {
                        ads.Fill(dt);
                        dd_FurType.DataSource = dt;
                        dd_FurType.DataBind();
                        dd_FurType.DataTextField = "Name";
                        dd_FurType.DataValueField = "Id";
                        dd_FurType.DataBind();
                        dd_FurType.Items.Insert(0, new ListItem("Select Fur Type"));
                    }
                }
            }
        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            string dob = tb_Dob.Text;
            int genderId;
            if (rbl_Gender.SelectedIndex==1)
            {
                genderId = 1;
            }
            else
            {
                genderId = 2;
            }
            string catType = dd_CatType.SelectedValue;
            string furType = dd_FurType.SelectedValue;
            string ConString = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            string insertQuery = "INSERT INTO Cats(Name, Dob, GenderId,CatType,FurType) Values(@Name,@Dob,@GenderId,@CatType,@FurType)";
            using(SqlConnection connection = new SqlConnection(ConString))
            {
                using(SqlCommand cmd = new SqlCommand(insertQuery))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Dob", dob);
                    cmd.Parameters.AddWithValue("@GenderId", genderId);
                    cmd.Parameters.AddWithValue("@CatType", catType);
                    cmd.Parameters.AddWithValue("@FurType", furType);
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            LoadBindGridView(ConString);
        }

        protected void gv_cats_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gv_cats.EditIndex = e.NewEditIndex;
            LoadDataFromCache();

        }

        protected void gv_cats_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gv_cats.EditIndex = -1;
            LoadDataFromCache();
        }

        protected void gv_cats_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Cats"].Rows.Find(e.Keys["Id"]);//Name, Dob, GenderId,CatType,FurType
                dr["Name"]= e.NewValues["Name"];
                dr["Dob"] = e.NewValues["Dob"];
                dr["GenderId"] = e.NewValues["GenderId"];
                dr["CatType"] = e.NewValues["CatType"];
                dr["FurType"] = e.NewValues["FurType"];
                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                gv_cats.EditIndex = -1;
                LoadDataFromCache();
            }

        }

        protected void gv_cats_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Cache["DATASET"] != null)
            {
                DataSet ds = (DataSet)Cache["DATASET"];
                DataRow dr = ds.Tables["Cats"].Rows.Find(e.Keys["Id"]);
                dr.Delete();
                Cache.Insert("DATASET", ds, null, DateTime.Now.AddHours(24), System.Web.Caching.Cache.NoSlidingExpiration);
                LoadDataFromCache();
            }

        }

        protected void btn_fromDb_Click(object sender, EventArgs e)
        {
            string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            this.LoadBindGridView(Constring);
        }

        protected void btn_updateDB_Click(object sender, EventArgs e)
        {
            string Constring = ConfigurationManager.ConnectionStrings["PetDbConnectionString"].ConnectionString;
            string Query = "select id, Name,Dob, GenderId, catType, FurType from Cats";
            SqlConnection con = new SqlConnection(Constring);
            SqlDataAdapter ad = new SqlDataAdapter(Query,con);
            DataSet ds = (DataSet)Cache["DATASET"];
            string strUpdateCmd = "Update Cats set Name = @Name, Dob = @Dob, GenderId = @GenderId, catType = @catType, FurType = @FurType where Id = @Id";
            SqlCommand updateCommand = new SqlCommand(strUpdateCmd, con);
            updateCommand.Parameters.Add("@Name", SqlDbType.VarChar, 100, "Name");
            updateCommand.Parameters.Add("@Dob", SqlDbType.DateTime, 0, "Dob");
            updateCommand.Parameters.Add("@GenderId", SqlDbType.Int, 0, "GenderId");
            updateCommand.Parameters.Add("@catType", SqlDbType.Int, 100, "catType");
            updateCommand.Parameters.Add("@FurType", SqlDbType.Int, 100, "FurType");
            updateCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            ad.UpdateCommand = updateCommand;

            string StrDelete = "Delete from Cats where Id = @Id";
            SqlCommand deleteCommand = new SqlCommand(StrDelete, con);
            deleteCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            ad.DeleteCommand = deleteCommand;


            ad.Update(ds, "Cats");
            lbl_Display.Text = "Data Updated in DB";
        }
    }
}