using ScholarsNest.Controler;
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
    public partial class RequestedStudentViewAdmin: Form
    {
        
        public RequestedStudentViewAdmin()
        {
            InitializeComponent();
            
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        string emails;
        private void acceptButton_Click(object sender, EventArgs e)
        {
            emails = emailText.Text;

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

            

            // now send to acceptedStudent tables;
            AcceptedStudent ss = new AcceptedStudent(name, fatherName, email, phone, institution, DOB, gender, address, password);

            AcceptedStudentController sc = new AcceptedStudentController();
            sc.AddAcceptedStudent(ss);



            // delete korbo requested table theke
            RequestedStudentController rsc = new RequestedStudentController();
            rsc.DeleteRequestedStudent(emails);

            emailText.Clear();


            MessageBox.Show("Student Added Successfully!");
            dataGridView1.DataSource = rsc.GetAllRequestedStudent();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView1.Rows[e.RowIndex];

                emailText.Text = dvr.Cells[2].Value.ToString();

            }
        }

        private void RequestedStudentViewAdmin_Load(object sender, EventArgs e)
        {
            RequestedStudentController pc = new RequestedStudentController();
            dataGridView1.DataSource = pc.GetAllRequestedStudent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDeshboard ad = new AdminDeshboard();
            ad.Show();
            this.Hide();
        }
    }
}
