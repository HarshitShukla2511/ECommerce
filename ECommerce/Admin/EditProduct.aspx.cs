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
    public partial class EditProduct : System.Web.UI.Page
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string id = Request.QueryString["id"];
          
            if(id == null || id == "")
            {
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                FileUpload1.Visible = false;
                Button1.Visible = false;
            }
            else
            {
                
                TextBox5.Visible = false;
                Button2.Visible = false;
                DBWork db = new DBWork();
                db.reader = db.SelectData(id);
                if (db.reader.Read())
                {
                    if (!IsPostBack)
                    {
                        TextBox1.Text = db.reader["productname"].ToString();
                        TextBox2.Text = db.reader["Price"].ToString();
                        TextBox3.Text = db.reader["dpc"].ToString();
                        TextBox4.Text = db.reader["Type"].ToString();
                        TextBox5.Text = id;
                    }
                   
                }
            }
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBWork db = new DBWork();
           db.reader =  db.SelectData(TextBox5.Text);
            if (db.reader.Read())
            {
                TextBox1.Text = db.reader["productname"].ToString();
                TextBox2.Text = db.reader["Price"].ToString();
                TextBox3.Text = db.reader["dpc"].ToString();
                TextBox4.Text = db.reader["Type"].ToString();
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                FileUpload1.Visible = true;
                Button1.Visible = true;
                TextBox5.Visible = false;
                Button2.Visible = false;
            }
            else
            {
                Response.Write("<script>alert('Data Not Found')</script>");
            }


           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                sc.Open();

                string fileName = Path.GetFileName(FileUpload1.FileName);

                string qry = $"update productdtl set Productname = '{TextBox1.Text}', price = '{TextBox2.Text}', dpc = '{TextBox3.Text}', Type = '{TextBox4.Text}', img = '{fileName}'  where  id = {TextBox5.Text}";

                SqlCommand scm = new SqlCommand(qry, sc);
                int i = scm.ExecuteNonQuery();
                if (i > 0)
                {
                    string folderPath = Server.MapPath("~/img/");
                    FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
                    Response.Write("<script>alert('Data Update SuccessFully .....')</script>");
                }
                    
            }
            else
            {
                sc.Open();
                string qry = $"update productdtl set Productname = '{TextBox1.Text}', price = '{TextBox2.Text}', dpc = '{TextBox3.Text}', Type = '{TextBox4.Text}'  where  id = {TextBox5.Text}";

                SqlCommand scm = new SqlCommand(qry,sc);
               int i = scm.ExecuteNonQuery();
                if(i > 0)
                    Response.Write("<script>alert('Data Update SuccessFully .....')</script>");
            }
        }
    }
}