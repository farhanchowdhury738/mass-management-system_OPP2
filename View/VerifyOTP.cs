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
    public partial class VerifyOTP : Form
    {
        string randomcode;
        public VerifyOTP(string code)
        {
            InitializeComponent();
            this.randomcode = code;
        }

        private void VerifyOTP_Load(object sender, EventArgs e)
        {
            if (randomcode == (verifyOTPTextBox.Text).ToString())
            {
                MessageBox.Show("Okay");
            }
            else if (randomcode != (verifyOTPTextBox.Text).ToString())
            {
                MessageBox.Show("wrong code!");
            }
            

        }
    }
}
