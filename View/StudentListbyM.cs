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
    public partial class StudentListbyM: Form
    {
        public StudentListbyM()
        {
            InitializeComponent();
        }

        private void StudentListbyM_Load(object sender, EventArgs e)
        {
            StudentController pc = new StudentController();
            dataGridView1.DataSource = pc.GetAllStudent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (emailTextBox.Text=="")
            {
                MessageBox.Show("Enter E-mail First!");
                return;
            }
            try
            {

                string email = emailTextBox.Text;

                StudentController pc = new StudentController();

                pc.DeleteStudent(email);

                MessageBox.Show("Student Deleted Successflly");

                nameTextBox.Clear();
                fatherNameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                institutionTextBox.Clear();
                //addmissionDateTimePicker
                addressTextBox.Clear();
                passwordTextBox.Clear();

                dataGridView1.DataSource = pc.GetAllStudent();
                dataGridView1.Refresh();

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" ||
                fatherNameTextBox.Text == "" ||
                emailTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                institutionTextBox.Text == "" ||
                addressTextBox.Text == "" ||
                passwordTextBox.Text == "")

                {
                    MessageBox.Show("Please fill all fields and select gender.");
                    return;
                }



                string name = nameTextBox.Text;
                string fatherName = fatherNameTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string institution = institutionTextBox.Text;
                string address = addressTextBox.Text;
                string password = passwordTextBox.Text;
                string dob = addmissionDateTimePicker.Text;
                string gender = "";
                if (maleRadioButton.Checked)
                {
                    gender = maleRadioButton.Text;
                }
                else if (femaleRadioButton.Checked)
                {
                    gender = femaleRadioButton.Text;
                }


                Student ss = new Student(name, fatherName, email, phone, institution, dob, gender, address, password);

                StudentController sc = new StudentController();
                sc.AddStudent(ss);

                nameTextBox.Clear();
                fatherNameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                institutionTextBox.Clear();
                addressTextBox.Clear();
                passwordTextBox.Clear();


                MessageBox.Show("Student Added Successfully!");

                dataGridView1.DataSource = sc.GetAllStudent();
                dataGridView1.Refresh();
            }

            catch (Exception exp)
            {
                //MessageBox.Show(exp.StackTrace);
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            fatherNameTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            institutionTextBox.Clear();
            //addmissionDateTimePicker.Text = dvr.Cells[5].Value.ToString();
            addressTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "" ||
                fatherNameTextBox.Text == "" ||
                emailTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                institutionTextBox.Text == "" ||
                addressTextBox.Text == "" ||
                passwordTextBox.Text == "" )
                {
                    MessageBox.Show("Please fill all fields and select gender.");
                    return;
                }



                string name = nameTextBox.Text;
                string fatherName = fatherNameTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string institution = institutionTextBox.Text;
                string address = addressTextBox.Text;
                string password = passwordTextBox.Text;
                string dob = addmissionDateTimePicker.Text;
                string gender = "";
                if (maleRadioButton.Checked)
                {
                    gender = maleRadioButton.Text;
                }
                else if (femaleRadioButton.Checked)
                {
                    gender = femaleRadioButton.Text;
                }




                Student ss = new Student(name, fatherName, email, phone, institution, dob, gender, address, password);

                StudentController sc = new StudentController();
                sc.UpdateStudent(ss);

                nameTextBox.Clear();
                fatherNameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                institutionTextBox.Clear();
                addressTextBox.Clear();
                passwordTextBox.Clear();


                MessageBox.Show("Student Updated Successfully!");

                dataGridView1.DataSource = sc.GetAllStudent();
                dataGridView1.Refresh();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.StackTrace);
            }
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

                    StudentController sc = new StudentController();
                    dataGridView1.DataSource = sc.GetAllStudent();
                    dataGridView1.Refresh();
                    
                }

            }

            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView1.Rows[e.RowIndex];

                nameTextBox.Text = dvr.Cells[0].Value.ToString();
                fatherNameTextBox.Text = dvr.Cells[1].Value.ToString();
                emailTextBox.Text = dvr.Cells[2].Value.ToString();
                phoneTextBox.Text = dvr.Cells[3].Value.ToString();
                institutionTextBox.Text = dvr.Cells[4].Value.ToString();
                //addmissionDateTimePicker.Text = dvr.Cells[5].Value.ToString();
                //gender
                addressTextBox.Text = dvr.Cells[7].Value.ToString();
                passwordTextBox.Text = dvr.Cells[8].Value.ToString();
                //emailTextBox.Enabled = false;
            }
        }
    }
}
