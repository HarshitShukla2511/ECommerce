using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce.Admin
{
    public partial class PostNewItems : System.Web.UI.Page
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                        sc.Open();
            string imgname = FileUpload1.FileName;

            
            string query = $"insert into productdtl values('{TextBox1.Text}','{TextBox2.Text}','{TextBox3.Text}','{TextBox4.Text}','{imgname}')";

            SqlCommand scm = new SqlCommand(query, sc);
            int i = scm.ExecuteNonQuery();
            if (i > 0)
            {
                string folderPath = Server.MapPath("~/img/");
                FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
                Response.Write("Product Successfully posted.......");

            }
           
        }
    }
}