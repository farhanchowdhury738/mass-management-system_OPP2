using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class RequestedStudentController
    {
        public void AddRequestedStudent(RequestedStudent s)
        {
            RequestedStudents cls = new RequestedStudents();
            cls.AddRequestedStudent(s);
        }

        public void DeleteRequestedStudent(string email)
        {
            RequestedStudents ps = new RequestedStudents();
            ps.DeleteRequestedStudent(email);
        }

        public List<RequestedStudent> GetAllRequestedStudent()
        {
            RequestedStudents ps = new RequestedStudents();
            List<RequestedStudent> RequestedStudentList = ps.GetAllRequestedStudent();
            return RequestedStudentList;
        }
    }
}
