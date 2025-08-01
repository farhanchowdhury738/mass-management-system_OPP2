using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Admin
    {
        //private string adminId;
        private string employeeId;
        private string name;
        private string salary;
        private string password;
        private string role;

        public Admin() { }

        public Admin(string employeeId, string name, string salary, string password, string role)
        {
            
            this.employeeId = employeeId;
            this.name = name;
            this.salary = salary;
            this.password = password;
            this.role = role;
        }

        
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string Name { get => name; set => name = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
