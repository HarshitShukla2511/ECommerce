using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            string qry = $"select * from userdtl where userId = '{TextBox1.Text}'";
            SqlCommand scm = new SqlCommand(qry, sc);
            SqlDataReader dr = scm.ExecuteReader();

            if (dr.Read())
            {
                if (TextBox1.Text == dr["userid"].ToString())
                {
                    if (TextBox2.Text == dr["Password"].ToString())
                    {
                        Session["userid"] = TextBox1.Text;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Password')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid UserName')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Admin')</script>");
            }

        }
    }
}