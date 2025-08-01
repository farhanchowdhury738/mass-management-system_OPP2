using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ScholarsNest.View
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void remembermecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text.Trim();
            string password = passwordText.Text;

            //SqlDbDataAccess sda = new SqlDbDataAccess();


            if (usernameText.Text == "" || passwordText.Text==" ")
            {
                MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlDbDataAccess sda = new SqlDbDataAccess();

                // --------- Admin ---------
                SqlCommand adminCmd = sda.GetQuery("SELECT * FROM Admin WHERE adminId = @id AND password = @password");
                adminCmd.Parameters.AddWithValue("@id", username);
                adminCmd.Parameters.AddWithValue("@password", password);

                DataTable adminTable = sda.GetData(adminCmd);
                if (adminTable.Rows.Count > 0)
                {
                    this.Hide();
                    new AdminDeshboard().Show();
                    return;
                }

                // --------- Manager ---------
                SqlCommand empCmd = sda.GetQuery("SELECT * FROM Employee WHERE employeeId = @id AND password = @password");
                empCmd.Parameters.AddWithValue("@id", username);
                empCmd.Parameters.AddWithValue("@password", password);

                DataTable empTable = sda.GetData(empCmd);
                if (empTable.Rows.Count > 0)
                {
                    this.Hide();
                    new Manager().Show();
                    return;
                }

                // --------- Student ---------
                SqlCommand stuCmd = sda.GetQuery("SELECT * FROM Student WHERE email = @id AND password = @password");
                stuCmd.Parameters.AddWithValue("@id", username);
                stuCmd.Parameters.AddWithValue("@password", password);

                DataTable stuTable = sda.GetData(stuCmd);
                if (stuTable.Rows.Count > 0)
                {
                    this.Hide();
                    new StudentDeshboard(username).Show();
                    //new PremiumStudent(username).Show();
                    return;
                }

                // --------- Premium Student (AcceptedStudent) --------- [future update]
                SqlCommand premiumCmd = sda.GetQuery("SELECT * FROM AcceptedStudent WHERE id = @id AND password = @password");
                premiumCmd.Parameters.AddWithValue("@id", username);
                premiumCmd.Parameters.AddWithValue("@password", password);

                DataTable premiumTable = sda.GetData(premiumCmd);
                if (premiumTable.Rows.Count > 0)
                {
                    SqlCommand cmd = sda.GetQuery("SELECT email FROM AcceptedStudent WHERE id = @id;");
                    cmd.Parameters.AddWithValue("@id", username);

                    string email = "";
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            email = reader["email"].ToString();
                        }
                    }
                    cmd.Connection.Close();

                    this.Hide();
                    new PremiumStudent(email).Show();
                    return;
                }

                // If no match found
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Login failed due to a database error.\n\nDetails: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void forgotpasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome www = new Welcome();
            www.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Only for students!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                VerifyEmail ve = new VerifyEmail();
                this.Hide();
                ve.Show();
            }
            else
            {
                MessageBox.Show("Access denied to non-students.");
            }

            
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            Admission ad = new Admission();
            this.Hide();
            ad.Show();
        }

        private void showpasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void showPassCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordText.UseSystemPasswordChar = true;
            }
            else
            {
                passwordText.UseSystemPasswordChar = false;
            }
        }
    }
}
