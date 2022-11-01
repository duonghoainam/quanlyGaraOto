using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGaraOto.Model
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            return DBSQLServerUtils.GetDBConnection();
        }
    }
}
