using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KalingaManagementSystem.CustomExceptions
{
    public class Exceptions
    {
        public static SqlConnection con = null;
        public SqlConnection Connect()
        {
            try
            {
                string stringconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=CampusMindDB;Integrated Security=True";
                con = new SqlConnection(stringconnection);
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong\n" + e);
            }
            return con;
        }
    }
}
