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
    public partial class BuyProduct : System.Web.UI.Page
    {
       


        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("login.aspx");
            }

            string pid = Request.QueryString["id"];
                sc.Open();
            string qry = $"select * from userdtl where userid = '{Session["userid"]}'";

            SqlCommand scm = new SqlCommand(qry, sc);
               SqlDataReader dr = scm.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr["UserName"].ToString();
                TextBox2.Text = dr["UserId"].ToString();
                TextBox3.Text = dr["Mobile"].ToString();
                TextBox4.Text = dr["address"].ToString();
                TextBox5.Text = dr["pincode"].ToString();
                TextBox6.Text = dr["state"].ToString();
                TextBox7.Text = dr["District"].ToString();
                sc.Close();
            }

            sc.Open();
            if (!String.IsNullOrEmpty(pid))
            {
                string query = $"select * from productdtl where id = { pid}";
                SqlCommand scm1 = new SqlCommand(query, sc);
                SqlDataReader dr1 = scm1.ExecuteReader();
                if (dr1.Read())
                {
                    string imageName = dr1["img"].ToString();
                    Image.Src = $"/img/{imageName}";
                    head1.InnerText = dr1["ProductName"].ToString();
                    TextBox10.Text = dr1["dpc"].ToString();
                    TextBox11.Text = dr1["type"].ToString();

                    int pCost = Convert.ToInt32(dr1["price"]);
                    int dCost = 0;
                    int ToTalCost = pCost - dCost;
                    Label1.Text = pCost.ToString();
                    Label2.Text = dCost.ToString();
                    Label3.Text = ToTalCost.ToString();


                }
            }



        }
    }
}