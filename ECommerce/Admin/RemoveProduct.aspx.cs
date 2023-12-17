using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce.Admin
{
    public partial class RemoveProduct : System.Web.UI.Page
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string id = Request.QueryString["id"];
            if(id == null)
            {
                Response.Redirect("AllProduct.aspx");
            }

            sc.Open();
            string query = $"delete from Productdtl where id = {id}";
           int i =  new SqlCommand(query, sc).ExecuteNonQuery();
            if (i > 0)
                Response.Redirect("AllProduct.aspx");

        }
    }
}