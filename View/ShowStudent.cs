using ScholarsNest.Controler;
using ScholarsNest.Model;
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
    public partial class ShowStudent : Form
    {
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void showStudentPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            StudentController pc = new StudentController();
            dataGridView1.DataSource = pc.GetAllStudent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDeshboard ad = new AdminDeshboard();
            ad.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = searchText.Text;


                StudentController pc = new StudentController();

                Student p = pc.SearchStudentByEmail(email);


                if (p != null)
                {
                    // Show result in DataGridView
                    dataGridView1.DataSource = new List<Student> { p };
                    dataGridView1.Refresh();

                    
                }
                else
                {
                    MessageBox.Show("Student not found.");
                    dataGridView1.DataSource = null;
                }

            }

            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
    }
}
