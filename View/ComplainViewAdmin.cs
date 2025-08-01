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
    public partial class ComplainViewAdmin: Form
    {
        public ComplainViewAdmin()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDeshboard ad = new AdminDeshboard();
            ad.Show();
            this.Hide();
        }

        

        private void ComplainViewAdmin_Load(object sender, EventArgs e)
        {
            ComplainController pc = new ComplainController();
            dataGridView1.DataSource = pc.GetAllComplain();

        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        string emails;
        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                emails = emailText.Text.Trim();

                SqlCommand cmd = sda.GetQuery("SELECT * FROM Student WHERE email = @email;");
                cmd.Parameters.AddWithValue("@email", emails);

                string name = "", fatherName = "", email = "", phone = "", institution = "", DOB = "", gender = "", address = "", password = "";

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
                    else
                    {
                        MessageBox.Show("No student found with that email.");
                        return;
                    }
                }
                cmd.Connection.Close();

                AcceptedStudent ss = new AcceptedStudent(name, fatherName, email, phone, institution, DOB, gender, address, password);
                AcceptedStudentController sc = new AcceptedStudentController();
                sc.AddAcceptedStudent(ss);

                SqlCommand cmd2 = sda.GetQuery("DELETE FROM Complaint WHERE StudentEmail = @email");
                cmd2.Parameters.AddWithValue("@email", emails);

                if (cmd2.Connection.State != ConnectionState.Open)
                    cmd2.Connection.Open();

                cmd2.ExecuteNonQuery();
                cmd2.Connection.Close();

                ComplainController pc = new ComplainController();
                dataGridView1.DataSource = pc.GetAllComplain();
                dataGridView1.Refresh();

                emailText.Clear();
                MessageBox.Show("Student complain accepted and complaint deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView1.Rows[e.RowIndex];

                emailText.Text = dvr.Cells[0].Value.ToString();
                
            }
        }
    }
}
