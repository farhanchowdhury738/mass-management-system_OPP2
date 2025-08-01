using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Controler
{
    public class AcceptedStudentController
    {
        public void AddAcceptedStudent(AcceptedStudent s)
        {
            AcceptedStudents cls = new AcceptedStudents();
            cls.AddAcceptedStudent(s);
        }

        public List<AcceptedStudent> GetAllAcceptedStudent()
        {
            AcceptedStudents ps = new AcceptedStudents();
            List<AcceptedStudent> AcceptedStudentList = ps.GetAllAcceptedStudent();
            return AcceptedStudentList;
        }
    }
}
