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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void showStudentListButton_Click(object sender, EventArgs e)
        {
            StudentListbyM sm = new StudentListbyM();
            this.Hide();
            sm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void showEmployeeListButton_Click(object sender, EventArgs e)
        {
            UpdateMealManager umm = new UpdateMealManager();
            this.Hide();
            umm.Show();
        }
    }
}
