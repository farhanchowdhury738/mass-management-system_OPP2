using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ScholarsNest.Interface;

namespace ScholarsNest.Model
{
    
    public class Students : IStudent
    {

        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddStudent(Student s)
        {
            // Attributes name, fatherName,email, phone, institution,dob, gender, address,password

            SqlCommand cmd = sda.GetQuery("INSERT INTO Student VALUES(@name,@fatherName, @email, @phone, @institution, @dob,@gender,@address, @password);");
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

        

        public void UpdateStudent(Student s)
        {
            SqlCommand cmd = sda.GetQuery("Update Student set  name=@name,fatherName=@fatherName, email=@email, phone=@phone, institution=@institution, dob=@dob, gender=@gender,address=@address, password=@password where email=@email;");
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


        public void UpdateStudentbyStudent(Student s)
        {
            SqlCommand cmd = sda.GetQuery("Update Student set  name=@name,fatherName=@fatherName, email=@email, phone=@phone, institution=@institution, address=@address, password=@password where email=@email;");
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@fatherName", s.FatherName);
            cmd.Parameters.AddWithValue("@email", s.Email);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@institution", s.Institution);
            cmd.Parameters.AddWithValue("@address", s.Address);
            cmd.Parameters.AddWithValue("@password", s.Password);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void UpdateStudentPassword(Student s)
        {
            SqlCommand cmd = sda.GetQuery("Update Student set password=@password where email=@email");
            cmd.Parameters.AddWithValue("@password", s.Password);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteStudent(string email)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Student WHERE email=@email;");
            cmd.Parameters.AddWithValue("@email", email);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public List<Student> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> studentList = new List<Student>();

            using (reader)
            {
                while (reader.Read())
                {
                    Student p = new Student();
                    p.Name = reader.GetString(0);
                    p.FatherName = reader.GetString(1);
                    p.Email = reader.GetString(2);
                    p.Phone = reader.GetString(3);
                    p.Institution = reader.GetString(4);
                    p.Dob = reader.GetString(5);
                    p.Gender = reader.GetString(6);
                    p.Address = reader.GetString(7);
                    p.Password = reader.GetString(8);

                    studentList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return studentList;
        }


        public Student SearchStudentByEmail(string email)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Student WHERE email=@email;");
            cmd.Parameters.AddWithValue("@email", email);
            cmd.CommandType = CommandType.Text;
            List<Student> StudentList = GetData(cmd);
            if (StudentList.Count > 0)
            {
                return StudentList[0];
            }

            else
            {
                return null;
            }
        }
        public List<Student> GetAllStudent()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Student;");
            cmd.CommandType = CommandType.Text;
            List<Student> studentList = GetData(cmd);
            return studentList;
        }



    }
}
