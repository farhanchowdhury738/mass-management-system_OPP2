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
    public partial class Facilities : Form
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void tackAddmissionButton_Click(object sender, EventArgs e)
        {
            HowToAdmit a = new HowToAdmit();
            a.Show();
            this.Hide();
        }

        private void facilitiesRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            
        }
    }
}
