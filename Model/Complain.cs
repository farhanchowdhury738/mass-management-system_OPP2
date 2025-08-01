using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Complain
    {
        private string studentEmail;
        private string subject;
        private string description;

        public string StudentEmail
        {
            get { return studentEmail; }
            set { studentEmail = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Complain() { }
        public Complain(string studentEmail, string subject, string description)
        {
            this.studentEmail = studentEmail;
            this.subject = subject;
            this.description = description;
        }
    }
}
