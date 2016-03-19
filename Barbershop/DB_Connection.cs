using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Barbershop
{
    class DB_Connection
    {
        // 
        public static SqlConnection newConn;
        public static string connString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        //definiranje konekcije
        public static SqlConnection GetConnection()
        {
            newConn = new SqlConnection(connString);
            return newConn; 
        }
    }
}
