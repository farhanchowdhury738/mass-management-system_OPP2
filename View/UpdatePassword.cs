using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarsNest.View
{
    public partial class UpdatePassword : Form
    {
        string email;
        public UpdatePassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string password = passwordTextBox.Text;
            string confirmPassword = textBox2.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("does not match new password and confirm password!");
            }
            else if (confirmPassword == "" || password == "")
            {
                MessageBox.Show("Please enter both confirm and new password.");
                return;
            }
            else if(password == confirmPassword)
            {
                SqlDbDataAccess sda = new SqlDbDataAccess();
                SqlCommand cmd = sda.GetQuery("UPDATE Student SET password = @password WHERE email = @email");
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully!");
                    Login lg = new Login();
                    this.Hide();
                    lg.Show();
                }
                else
                {
                    MessageBox.Show("Something is Wrong!");
                }
            }

        }
    }
}
