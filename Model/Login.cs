using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Login
    {
        private string email;
        private string password;

        public Login(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
