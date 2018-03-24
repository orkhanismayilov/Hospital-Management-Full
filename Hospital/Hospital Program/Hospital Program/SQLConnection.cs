using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Program
{
    public static class SQLCon
    {
        public static SqlConnection GetConnection()
        {
            string connection = "Data Source=SQL6004.site4now.net;Initial Catalog=DB_A38039_CODESERVER;User Id=DB_A38039_CODESERVER_admin;Password=Hospital303;";
            SqlConnection con = new SqlConnection(connection);
            return con;
        }
    }
}
