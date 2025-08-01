using ScholarsNest.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarsNest
{
    public partial class HowToAdmit: Form
    {
        public HowToAdmit()
        {
            InitializeComponent();
        }

        private void HowTo_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void AdmissionButton_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            this.Hide();
            a.Show();
        }
    }
}
