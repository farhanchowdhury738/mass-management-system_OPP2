using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScholarsNest.Model;

namespace ScholarsNest.Controler
{
    public class StudentController
    {

        public void AddStudent(Student s)
        {
            Students cls = new Students();
            cls.AddStudent(s);
        }
        public void UpdateStudent(Student p)
        {
            Students ps = new Students();
            ps.UpdateStudent(p);
        }

        public void UpdateStudentbyStudent(Student p)
        {
            Students ps = new Students();
            ps.UpdateStudentbyStudent(p);
        }

        public void DeleteStudent(string email)
        {
            Students ps = new Students();
            ps.DeleteStudent(email);
        }

        public Student SearchStudentByEmail(string email)
        {
            Students ps = new Students();
            Student p = ps.SearchStudentByEmail(email);
            return p;
        }


        public List<Student> GetAllStudent()
        {
            Students ps = new Students();
            List<Student> productList = ps.GetAllStudent();
            return productList;
        }


    }
}
