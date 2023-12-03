using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-UBSLDHDF\MSSQLSERVER1;Initial Catalog=btps;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            string qry = $"select * from Admindtl where userName = '{TextBox1.Text}'";
            SqlCommand scm = new SqlCommand(qry, sc);
           SqlDataReader dr =  scm.ExecuteReader();

            if (dr.Read())
            {
                if(TextBox1.Text == dr["UserName"].ToString())
                {
                    if(TextBox2.Text == dr["Password"].ToString())
                    {
                        Session["UserName"] = TextBox1.Text;
                        Response.Redirect("AllProduct.aspx");
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