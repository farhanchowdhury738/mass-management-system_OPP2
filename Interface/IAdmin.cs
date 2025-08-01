using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Interface
{
    interface IAdmin
    {
        void AddEmployee(Admin a);
        void UpdateEmployee(Admin a);
        void DeleteEmployee(string employeeId);
        List<Admin> GetAllEmployees();
    }
}
