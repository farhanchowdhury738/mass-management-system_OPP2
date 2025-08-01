using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScholarsNest.Controler;
using ScholarsNest.Model;

namespace ScholarsNest.View
{
    public partial class ShowEmpoyeeOp : Form
    {
        public ShowEmpoyeeOp()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminDeshboard ad = new AdminDeshboard();
            this.Hide();
            ad.Show();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            roleComboBox.SelectedIndex = -1;
            empIDTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
            passwordTextBox.Clear();
            empIDTextBox.Enabled = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
         

            try
            {
                if (empIDTextBox.Text == "" ||
                nameTextBox.Text == "" ||
                salaryTextBox.Text == "" ||
                passwordTextBox.Text == "" ||
                roleComboBox.Text == "")
                {
                    MessageBox.Show("Please fill all fields before adding employee.");
                    return;
                }

                string employeeId = empIDTextBox.Text;
                string name = nameTextBox.Text;
                string salary = salaryTextBox.Text;
                string password = passwordTextBox.Text;
                string role = roleComboBox.Text;


                Admin addEmp = new Admin(employeeId,name,salary,password,role);

                AdminController ad = new AdminController();
                ad.AddEmployee(addEmp);

                roleComboBox.SelectedIndex = -1;
                empIDTextBox.Clear();
                nameTextBox.Clear();
                salaryTextBox.Clear();
                passwordTextBox.Clear();

                MessageBox.Show("Employee Added Successfully!");

                dataGridView1.DataSource = ad.GetAllEmployee();
                dataGridView1.Refresh();
            }
            catch(Exception exp)
            {
                //MessageBox.Show(exp.StackTrace);
                MessageBox.Show("Error: " + exp.Message);
            }
            

        }

        private void empAListPanel_Paint(object sender, PaintEventArgs e)
        {
            AdminController pc = new AdminController();
            dataGridView1.DataSource = pc.GetAllEmployee();
        }

        private void salaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (empIDTextBox.Text == "")
            {
                MessageBox.Show("don't empty emply id");
            }
            else
            {
                try
                {
                    string employeeId = empIDTextBox.Text;

                    AdminController ad = new AdminController();
                    ad.DeleteEmployee(employeeId);

                    MessageBox.Show("Employee Deleted Successflly");

                    roleComboBox.SelectedIndex = -1;
                    empIDTextBox.Clear();
                    nameTextBox.Clear();
                    salaryTextBox.Clear();
                    passwordTextBox.Clear();

                    dataGridView1.DataSource = ad.GetAllEmployee();
                    dataGridView1.Refresh();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.StackTrace);
                }
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView1.Rows[e.RowIndex];

                empIDTextBox.Text = dvr.Cells[0].Value.ToString(); 
                nameTextBox.Text = dvr.Cells[1].Value.ToString();
                salaryTextBox.Text = dvr.Cells[2].Value.ToString();
                passwordTextBox.Text = dvr.Cells[3].Value.ToString();
                roleComboBox.Text = dvr.Cells[4].Value.ToString();

                //empIDTextBox.Enabled = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (empIDTextBox.Text == "" ||
                nameTextBox.Text == "" ||
                salaryTextBox.Text == "" ||
                passwordTextBox.Text == "" ||
                roleComboBox.Text == "")
                {
                    MessageBox.Show("Please fill all fields before adding employee.");
                    return;
                }


                string employeeId = empIDTextBox.Text;
                string name = nameTextBox.Text;
                string salary = salaryTextBox.Text;
                string password = passwordTextBox.Text;
                string role = roleComboBox.Text;


                Admin addEmp = new Admin(employeeId, name, salary, password, role);

                AdminController ad = new AdminController();
                ad.UpdateEmployee(addEmp);


                roleComboBox.SelectedIndex = -1;
                empIDTextBox.Clear();
                nameTextBox.Clear();
                salaryTextBox.Clear();
                passwordTextBox.Clear();
                empIDTextBox.Enabled = true;

                MessageBox.Show("Employee updated Successfully!");

                dataGridView1.DataSource = ad.GetAllEmployee();
                dataGridView1.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            string amount = salaryTextBox.Text;
            // Remove invalid characters
            salaryTextBox.Text = new string(amount.Where(ch => ch >= '0' && ch <= '9').ToArray());
            salaryTextBox.SelectionStart = salaryTextBox.Text.Length;
            return;
        }
    }
}
