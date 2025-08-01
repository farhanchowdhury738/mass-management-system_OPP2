using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScholarsNest.Model;
namespace ScholarsNest.Interface
{
   public interface IStudent
    {
         void AddStudent(Student a);
        void UpdateStudent(Student a);
        void DeleteStudent(string email);
        List<Student> GetAllStudent();
    }
}
