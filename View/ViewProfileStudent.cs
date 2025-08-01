using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarsNest.View
{
    public partial class ViewProfileStudent: Form
    {
        string user;
        public ViewProfileStudent(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void updatepassowrdButton_Click(object sender, EventArgs e)
        {
            // tar nijer sob info update korte parbe
            UpdateStudentProfile stu = new UpdateStudentProfile(user);
            this.Hide();
            stu.Show();

        }
        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void ViewProfileStudent_Load(object sender, EventArgs e)
        {
            string email = user; 

            SqlCommand cmd = sda.GetQuery("SELECT name,email,phone,institution,address FROM Student WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", email);


            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    nameLabel.Text = reader["name"].ToString();
                    emailLabel.Text = reader["email"].ToString();
                    phoneLabel.Text = reader["phone"].ToString();
                    institutionLabel.Text = reader["institution"].ToString();
                    addressLabel.Text = reader["address"].ToString();
                }
                else
                {
                    // nameText.Text = "Not found";
                }
            }

            
            cmd.Connection.Close();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            StudentDeshboard sd = new StudentDeshboard(user);
            sd.Show();
            this.Hide();
        }
    }
}
