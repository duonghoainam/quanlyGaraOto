using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraOto.Model
{
    public class DBSQLServerUtils
    {
        public static SqlConnection
        GetDBConnection()
        {
            string connString = @"Data Source=DESKTOP-PQJT8IB;Initial Catalog=GARA;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }


    }
}
