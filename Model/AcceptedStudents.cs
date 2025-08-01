using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class AcceptedStudents
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddAcceptedStudent(AcceptedStudent s)
        {
            // Attributes name, fatherName,email, phone, institution,dob, gender, address,password

            SqlCommand cmd = sda.GetQuery("INSERT INTO AcceptedStudent VALUES(@name,@fatherName, @email, @phone, @institution, @dob,@gender,@address, @password);");
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@fatherName", s.FatherName);
            cmd.Parameters.AddWithValue("@email", s.Email);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@institution", s.Institution);
            cmd.Parameters.AddWithValue("@dob", s.Dob);
            cmd.Parameters.AddWithValue("@gender", s.Gender);
            cmd.Parameters.AddWithValue("@address", s.Address);
            cmd.Parameters.AddWithValue("@password", s.Password);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public List<AcceptedStudent> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<AcceptedStudent> AcceptedStudentList = new List<AcceptedStudent>();

            using (reader)
            {
                while (reader.Read())
                {
                    AcceptedStudent p = new AcceptedStudent();
                    p.Name = reader.GetString(1);
                    p.FatherName = reader.GetString(2);
                    p.Email = reader.GetString(3);
                    p.Phone = reader.GetString(4);
                    p.Institution = reader.GetString(5);
                    p.Dob = reader.GetString(6);
                    p.Gender = reader.GetString(7);
                    p.Address = reader.GetString(8);
                    p.Password = reader.GetString(9);

                    AcceptedStudentList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return AcceptedStudentList;
        }


        public List<AcceptedStudent> GetAllAcceptedStudent()
        {
            SqlCommand cmd = sda.GetQuery("SELECT id,password FROM AcceptedStudent;");
            cmd.CommandType = CommandType.Text;
            List<AcceptedStudent> AcceptedStudentList = GetData(cmd);
            return AcceptedStudentList;
        }
 

    }
}
