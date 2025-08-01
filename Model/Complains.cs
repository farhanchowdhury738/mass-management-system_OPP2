using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Complains
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddComplain(Complain s)
        {

            SqlCommand cmd = sda.GetQuery("INSERT INTO Complaint VALUES(@studentemail ,@subject , @description);");
            cmd.Parameters.AddWithValue("@studentemail", s.StudentEmail);
            cmd.Parameters.AddWithValue("@subject", s.Subject);
            cmd.Parameters.AddWithValue("@description", s.Description);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public List<Complain> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Complain> complaintList = new List<Complain>();

            using (reader)
            {
                while (reader.Read())
                {
                    Complain p = new Complain();
                    p.StudentEmail = reader.GetString(1);
                    p.Subject = reader.GetString(2);
                    p.Description = reader.GetString(3);


                    complaintList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return complaintList;
        }


        public List<Complain> GetAllComplain()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Complaint;");
            cmd.CommandType = CommandType.Text;
            List<Complain> complaintList = GetData(cmd);
            return complaintList;
        }
    }
}
