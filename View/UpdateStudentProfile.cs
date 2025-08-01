using ScholarsNest.Controler;
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
    public partial class UpdateStudentProfile: Form
    {
        string user;
        public UpdateStudentProfile(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void UpdateStudentProfile_Load(object sender, EventArgs e)
        {
            string email = user;

            SqlCommand cmd = sda.GetQuery("SELECT name,fatherName,email,phone,institution,address,password FROM Student WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", email);


            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    nameTextBox.Text = reader["name"].ToString();
                    emailTextBox.Text = reader["email"].ToString();
                    fatherNameTextBox.Text = reader["fatherName"].ToString();
                    institutionTextBox.Text = reader["institution"].ToString();
                    addressTextBox.Text = reader["address"].ToString();
                    passwordTextBox.Text = reader["password"].ToString();
                    phoneTextBox.Text = reader["phone"].ToString();

                    emailTextBox.Enabled = false;
                    
                }
                else
                {
                    // nameText.Text = "Not found";
                }
            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string fatherName = fatherNameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string institution = institutionTextBox.Text;
            string address = addressTextBox.Text;
            string password = passwordTextBox.Text;

            Student ss = new Student(name, fatherName, email, phone, institution, address, password);

            StudentController sc = new StudentController();
            sc.UpdateStudentbyStudent(ss);

            MessageBox.Show("Student Updated Successfully!");

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PremiumViewProfileStudent stu = new PremiumViewProfileStudent(user);
            stu.Show();
            this.Hide();
        }
    }
}
