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
    public partial class AdminDeshboard : Form
    {
        public AdminDeshboard()
        {
            InitializeComponent();
        }

        private void showStudentListButton_Click(object sender, EventArgs e)
        {

            ShowStudent ss = new ShowStudent();
            ss.Show();
            this.Hide();
        }

        private void showEmployeeListButton_Click(object sender, EventArgs e)
        {
            ShowEmpoyeeOp showAllEmp = new ShowEmpoyeeOp();
            this.Hide();
            showAllEmp.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void complainlistText_Click(object sender, EventArgs e)
        {
            ComplainViewAdmin cvd = new ComplainViewAdmin();
            cvd.Show();
            this.Hide();
        }

        private void adminTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reqstudentButton_Click(object sender, EventArgs e)
        {
            RequestedStudentViewAdmin rsva = new RequestedStudentViewAdmin();
            this.Hide();
            rsva.Show();
        }
    }
}
