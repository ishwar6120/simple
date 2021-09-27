using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KalingaManagementSystem.CustomExceptions;
using KalingaManagementSystem.Entities;
using System.Data;

namespace KalingaManagementSystem.DataAccessLayer
{
    public class DataAccess
    {
        Exceptions except = new Exceptions();
        public void connection()
        {
            SqlConnection con = except.Connect();
        }

        // **************** ADD NEW Campus Mind Details *********************
        public int AddCampusMind(User user)
        {
            SqlConnection con = except.Connect();


            SqlCommand cmd = new SqlCommand("AddNewCampusMind", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
            cmd.Parameters.AddWithValue("@ContactNumber", user.ContactNumber);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@LeadId", user.LeadId);

            con.Open();
            var ans = cmd.ExecuteNonQuery();
            con.Close();

            return ans;
        }
    }
}
