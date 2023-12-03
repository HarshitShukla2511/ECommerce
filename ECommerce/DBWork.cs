using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ECommerce
{
    public class DBWork
    {
        SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-UBSLDHDF\MSSQLSERVER1;Initial Catalog=btps;Integrated Security=True");

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
    }
}