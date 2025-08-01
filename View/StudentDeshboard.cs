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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ScholarsNest.View
{
    public partial class StudentDeshboard: Form
    {
        string u;
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public StudentDeshboard(string user)
        {
            InitializeComponent();
            u = user;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userprofileCirclePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UserName\n Email\n Gender\n Password");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void depositebalanceButton_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(u);
            this.Hide();
            deposit.Show();
        }

        private void dashboardShadowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewmealButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void StudentDeshboard_Load(object sender, EventArgs e)
        {
            string email = u; 

            SqlCommand cmd = sda.GetQuery("SELECT name FROM Student WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", email);


            // Ensure connection is open before executing
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    studentnameLabel.Text = reader["name"].ToString();
                }
                else
                {
                    // nameText.Text = "Not found";
                }
            }

            
            cmd.Connection.Close();
        }

        

        private void studentnameLabel_Click(object sender, EventArgs e)
        {
            
            
        }

        private void studentnameLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void viewprofileButton_Click(object sender, EventArgs e)
        {
            ViewProfileStudent vp = new ViewProfileStudent(u);
            this.Hide();
            vp.Show();
        }

        private void complainButton_Click(object sender, EventArgs e)
        {
            StudentComplain stu = new StudentComplain(u);
            stu.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string email = u;

            SqlCommand cmd = sda.GetQuery("SELECT id,password FROM AcceptedStudent WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", email);


            // Ensure connection is open before executing
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string password = reader["password"].ToString();

                    string message = "🎉Congratulations! You are accepted.\n\n" +
                                     "ID:        " + id + "\n" +
                                     "Password:  " + password;

                    MessageBox.Show(message, "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string message = "😊 Don't worry, you're on the list,\nbut not yet selected.";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            cmd.Connection.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        
        private void admissionreqButton_Click(object sender, EventArgs e)
        {
            string emails = u;

            // email diye student sob info nibo then requestStudent e send korbo
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Student WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", emails);

            string name = "";
            string fatherName = "";
            string email = "";
            string phone = "";
            string institution = "";
            string DOB = "";
            string gender = "";
            string address = "";
            string password = "";

            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    name = reader["name"].ToString();
                    fatherName = reader["fatherName"].ToString();
                    email = reader["email"].ToString();
                    phone = reader["phone"].ToString();
                    institution = reader["institution"].ToString();
                    DOB = reader["DOB"].ToString();
                    gender = reader["gender"].ToString();
                    address = reader["address"].ToString();
                    password = reader["password"].ToString();
                }
            }

            cmd.Connection.Close();


            RequestedStudent rs = new RequestedStudent(name,fatherName,email,phone,institution,DOB,gender,address,password);

            RequestedStudentController rsc = new RequestedStudentController();
            rsc.AddRequestedStudent(rs);

            MessageBox.Show("Successfully sent Request to Admin");
        }
    }
}
