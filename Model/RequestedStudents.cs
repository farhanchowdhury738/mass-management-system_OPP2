using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class RequestedStudents
    {

        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddRequestedStudent(RequestedStudent s)
        {
            // Attributes name, fatherName,email, phone, institution,dob, gender, address,password

            SqlCommand cmd = sda.GetQuery("INSERT INTO RequestedStudent VALUES(@name,@fatherName, @email, @phone, @institution, @dob,@gender,@address, @password);");
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

        public void DeleteRequestedStudent(string email)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM RequestedStudent WHERE email=@email;");
            cmd.Parameters.AddWithValue("@email", email);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public List<RequestedStudent> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<RequestedStudent> RequestedStudentList = new List<RequestedStudent>();

            using (reader)
            {
                while (reader.Read())
                {
                    RequestedStudent p = new RequestedStudent();
                    p.Name = reader.GetString(0);
                    p.FatherName = reader.GetString(1);
                    p.Email = reader.GetString(2);
                    p.Phone = reader.GetString(3);
                    p.Institution = reader.GetString(4);
                    p.Dob = reader.GetString(5);
                    p.Gender = reader.GetString(6);
                    p.Address = reader.GetString(7);
                    p.Password = reader.GetString(8);

                    RequestedStudentList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return RequestedStudentList;
        }


        public List<RequestedStudent> GetAllRequestedStudent()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM RequestedStudent;");
            cmd.CommandType = CommandType.Text;
            List<RequestedStudent> RequestedStudentList = GetData(cmd);
            return RequestedStudentList;
        }
    }
}
