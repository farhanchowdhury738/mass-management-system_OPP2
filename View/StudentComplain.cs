using ScholarsNest.Controler;
using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ScholarsNest.View
{
    public partial class StudentComplain: Form
    {
        string user;
        public StudentComplain(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void StudentComplain_Load(object sender, EventArgs e)
        {

        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void sentButton_Click(object sender, EventArgs e)
        {
            string subject = complainsubjectText.Text;
            string description = complaindescriptionText.Text;


            try
            {
                Complain complain = new Complain(user, subject, description);

                ComplainController cc = new ComplainController();
                cc.AddComplain(complain);

                complainsubjectText.Clear();
                complaindescriptionText.Clear();

                MessageBox.Show("Request has been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PremiumStudent ps = new PremiumStudent(user);
                ps.Show();
                this.Hide();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PremiumStudent sd = new PremiumStudent(user);
            sd.Show();
            this.Hide();
        }
    }
}
