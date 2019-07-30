using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BookStudyRoom
{
    class DBUtils
    {
        public static String currentUserID = "";
        public static SqlConnection GetDBConnection()
        {            
            String connectionString = "Data Source=localhost;Initial Catalog=roombooking;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
            
        }
    }
}
