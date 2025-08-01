using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarsNest.View
{
    public partial class Welcome: Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            HowToAdmit hw = new HowToAdmit();
            this.Hide();
            hw.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void facilitesButton_Click(object sender, EventArgs e)
        {
            Facilities f = new Facilities();
            this.Hide();
            f.Show();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs ab = new AboutUs();
            ab.Show();
        }
    }
}
