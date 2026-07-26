using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace النظام_النهائي
{
    public class Connection
    {
        public SqlConnection Connect()
        {
            // قراءة السلسلة من App.config
            string strCon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


            return new SqlConnection(strCon);
        }
    }
}