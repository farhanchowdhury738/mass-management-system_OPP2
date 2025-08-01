using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Student
    {
        private string name;
        private string fatherName;
        private string email;
        private string phone;
        private string institution;
        private string address;
        private string password;

        private string dob;
        private string gender;

        public Student() { }


        public Student(string name, string email, string institution, string password)
        {
            this.name = name;
            this.email = email;
            this.institution = institution;
            this.password = password;
        }

        public Student(string name, string fatherName, string email, string phone, string institution, string address, string password)
        {
            this.name = name;
            this.fatherName = fatherName;
            this.email = email;
            this.phone = phone;
            this.institution = institution;
            this.address = address;
            this.password = password;
        }

        public Student(string name, string fatherName, string email, string phone, string institution, string dob, string gender, string address, string password)
        {
            this.name = name;
            this.fatherName = fatherName;
            this.email = email;
            this.phone = phone;
            this.institution = institution;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string FatherName { get => fatherName; set => fatherName = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Institution { get => institution; set => institution = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Password { get => password; set => password = value; }
    }
}
