using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ScholarsNest.Interface;


namespace ScholarsNest.Model
{
    public class Admins: IAdmin
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddEmployee(Admin a)
        {

            SqlCommand cmd = sda.GetQuery("INSERT INTO Employee VALUES(@employeeId, @name, @salary, @password, @role);");
            cmd.Parameters.AddWithValue("@employeeId", a.EmployeeId);
           // cmd.Parameters.AddWithValue("@adminId", a.AdminId);
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@salary", a.Salary);
            cmd.Parameters.AddWithValue("@password", a.Password);
            cmd.Parameters.AddWithValue("@role", a.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateEmployee(Admin a)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Employee SET  name=@name, salary=@salary, password=@password, role=@role WHERE employeeId=@employeeId;");
            cmd.Parameters.AddWithValue("@employeeId", a.EmployeeId);
            //cmd.Parameters.AddWithValue("@adminId", a.AdminId);
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@salary", a.Salary);
            cmd.Parameters.AddWithValue("@password", a.Password);
            cmd.Parameters.AddWithValue("@role", a.Role);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void DeleteEmployee(string employeeId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Employee WHERE employeeId=@employeeId;");
            cmd.Parameters.AddWithValue("@employeeId", employeeId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }



        public List<Admin> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Admin> employeeList = new List<Admin>();

            // @employeeId, @adminId, @name, @salary, @password, @role)

            using (reader)
            {
                while (reader.Read())
                {
                    Admin p = new Admin();
                    p.EmployeeId = reader.GetString(0);
                    //p.AdminId = reader.GetString(1);
                    p.Name = reader.GetString(1);
                    p.Salary = reader.GetString(2);
                    p.Password = reader.GetString(3);
                    p.Role = reader.GetString(4);

                    employeeList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return employeeList;
        }


        public List<Admin> GetAllEmployees()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM employee;");
            cmd.CommandType = CommandType.Text;
            List<Admin> employeeList = GetData(cmd);
            return employeeList;
        }




    }
}
