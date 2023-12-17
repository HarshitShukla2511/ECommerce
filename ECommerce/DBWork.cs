using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ECommerce
{
    public class DBWork
    {
        SqlConnection sc = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString);

        public SqlDataReader reader;
        public SqlDataReader SelectData()
        {
            sc.Open();
            string qry = $"select * from productdtl";
            SqlCommand scm = new SqlCommand(qry, sc);
            return scm.ExecuteReader();
        }

        public SqlDataReader SelectData(string id)
        {
            sc.Open();
            string qry = $"select * from productdtl where id = {id}";
            SqlCommand scm = new SqlCommand(qry, sc);
            return scm.ExecuteReader();
        }

        public SqlDataReader SelectTypeClothes()
        {
            sc.Open();
            string qry = $"select * from productdtl where type = 'cloths'";
            SqlCommand scm = new SqlCommand(qry, sc);
            return scm.ExecuteReader();
        }

        public SqlDataReader SelectTypeElectrpnic()
        {
            sc.Open();
            string qry = $"select * from productdtl where type = 'electronic'";
            SqlCommand scm = new SqlCommand(qry, sc);
            return scm.ExecuteReader();
        }

        public SqlDataReader SelectTypeJwallery()
        {
            sc.Open();
            string qry = $"select * from productdtl where type = 'Jewellery '";
            SqlCommand scm = new SqlCommand(qry, sc);
            return scm.ExecuteReader();
        }
    }
}