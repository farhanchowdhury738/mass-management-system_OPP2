using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ScholarsNest.View
{
    public partial class VerifyEmail : Form
    {
        public VerifyEmail()
        {
            InitializeComponent();
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            Login LG = new Login();
            LG.Show();
            this.Hide();
        }

       

        private void verifyEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void submitOTPButton_Click(object sender, EventArgs e)
        {

            randomCode = randomcode.ToString();

            if (randomCode == (verifyOTPTextBox.Text).ToString())
            {
                to = verifyOTPTextBox.Text;
                MessageBox.Show("Okay");
                UpdatePassword up = new UpdatePassword(email);
                this.Hide();
                up.Show();
            }
            else if (randomCode != (verifyOTPTextBox.Text).ToString())
            {
                MessageBox.Show("wrong code!");
            }
            

        }

        public static string to;
        int randomcode;
        String from, pass, msgbody;
        Random rand = new Random();
        String randomCode;

        private void verifyTitleLabel_Click(object sender, EventArgs e)
        {

        }

        string email;

        private void verifyButton_Click(object sender, EventArgs e)
        {
            
            email = verifyEmailTextBox.Text;

            SqlDbDataAccess sda = new SqlDbDataAccess();

            SqlCommand cmd = sda.GetQuery("SELECT * FROM Student WHERE email = @email");
            cmd.Parameters.AddWithValue("@email", email);

            DataTable dt = sda.GetData(cmd);

            if (dt.Rows.Count > 0)
            {
                //if found then work here now
                randomcode = rand.Next(100000, 1000000);
                //MessageBox.Show(randomcode.ToString());
                string randomCode = randomcode.ToString();

                MailMessage message = new MailMessage();
                to = (verifyEmailTextBox.Text).ToString();
                from = "farhanahmed7389@gmail.com";
                pass = "wbbopuyqzauduckk";
                msgbody = "Your OTP code is " + randomcode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = msgbody;
                message.Subject = "OTP Sending";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Succesfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                

            }
            else
            {
                MessageBox.Show("Email not found.");
            }

        }
    }
}
