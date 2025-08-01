using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Controler
{
    public class AdminController
    {
        public void AddEmployee(Admin a)
        {
            Admins cls = new Admins();
            cls.AddEmployee(a);
        }


        public void UpdateEmployee(Admin a)
        {
            Admins cls = new Admins();
            cls.UpdateEmployee(a);

        }

        public void DeleteEmployee(string empId)
        {
            Admins cls = new Admins();
            cls.DeleteEmployee(empId);
        }

        public List<Admin> GetAllEmployee()
        {
            Admins ps = new Admins();
            List<Admin> employeeList = ps.GetAllEmployees();
            return employeeList;
        }
    }
}
