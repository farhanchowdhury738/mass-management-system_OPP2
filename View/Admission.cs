using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using ScholarsNest.Controler;
using ScholarsNest.Model;

namespace ScholarsNest.View
{
    public partial class Admission: Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text=="" ||
                fatherNameTextBox.Text=="" ||
                emailTextBox.Text=="" ||
                phonenoTextBox.Text == "" ||
                InstitutionTextBox.Text == "" ||
                addressTextBox.Text == "" ||
                passwordTextBox.Text == "" ||
                (!maleRadioButton.Checked && !femaleRadioButton.Checked))
            {
                MessageBox.Show("Please fill in all the required fields and select your gender.");
                return;
            }


            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your name.");
                return;
            }
            if (fatherNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter your father's name.");
                return;
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            if (phonenoTextBox.Text == "")
            {
                MessageBox.Show("Please enter your phone number.");
                return;
            }
            if (InstitutionTextBox.Text == "")
            {
                MessageBox.Show("Please enter your institution.");
                return;
            }
            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please enter your address.");
                return;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter your password.");
                return;
            }
            if (!maleRadioButton.Checked && !femaleRadioButton.Checked)
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            string name = nameTextBox.Text;
            string fatherName = fatherNameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phonenoTextBox.Text;
            string institution = InstitutionTextBox.Text;
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

            try
            {
                Student ss = new Student(name, fatherName, email, phone, institution, dob, gender, address, password);
                StudentController sc = new StudentController();
                sc.AddStudent(ss);

                nameTextBox.Clear();
                fatherNameTextBox.Clear();
                emailTextBox.Clear();
                phonenoTextBox.Clear();
                InstitutionTextBox.Clear();
                addressTextBox.Clear();
                passwordTextBox.Clear();
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;

                MessageBox.Show("Your Admission has confirm!");

                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }



        }

        private void fillFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        bool f = false;
        bool flag4 = false;
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;



            for (int i = 0; i < email.Length; i++)
            {

                if (email[i] == '@')
                {
                    for (int j = 0; j < email.Length; j++)
                    {
                        if (email[j] == '.')
                        {
                            f = true;
                            break;
                        }
                    }
                    if (f == true) { break; }



                }
                else f = false;


            }
            if (f == false)
            {
                emailTextBox.ForeColor = Color.Red;
                emailTaken.Visible = true;
                flag4 = false;
            }
            else
            {
                emailTextBox.ForeColor = Color.Green;
                emailTaken.Visible = false;
                flag4 = true;
            }
        }

        bool flag = false;

        private void phonenoTextBox_TextChanged(object sender, EventArgs e)
        {
            string phone = phonenoTextBox.Text;




            
            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                {
                    phonenoTextBox.ForeColor = Color.Red;
                    phoneTaken.Visible = true;
                    phoneTaken.Text = "Only numbers are allowed.";
                    tickPicture2.Visible = false;
                    crossPicture2.Visible = true;
                    flag = false;

                    
                    phonenoTextBox.Text = new string(phone.Where(ch => ch >= '0' && ch <= '9').ToArray());
                    phonenoTextBox.SelectionStart = phonenoTextBox.Text.Length;
                    return;
                }
            }

            
            if (phone.Length != 11)
            {
                phonenoTextBox.ForeColor = Color.Red;
                phoneTaken.Visible = true;
                phoneTaken.Text = "Phone number must be exactly 11 digits.";
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                return;
            }

            
            if (phone[0] != '0' || phone[1] != '1')
            {
                phonenoTextBox.ForeColor = Color.Red;
                phoneTaken.Visible = true;
                phoneTaken.Text = "Phone number must start with '01'.";
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                return;
            }

            
            phonenoTextBox.ForeColor = Color.Green;
            phoneTaken.Visible = false;
            tickPicture2.Visible = true;
            crossPicture2.Visible = false;
            flag = true;
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void minimumCharacter_Click(object sender, EventArgs e)
        {

        }

        bool flag3 = false;
        bool flag2 = false;
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

            string pass = passwordTextBox.Text;
            string specialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";

            bool hasUpper = pass.Any(char.IsUpper);
            bool hasLower = pass.Any(char.IsLower);
            bool hasDigit = pass.Any(char.IsDigit);
            bool hasSpecial = pass.Any(ch => specialChars.Contains(ch));

            // Check password strength
            if (pass.Length < 8)
            {
                passwordTextBox.ForeColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                minimumCharacter.Text = "Password must be at least 8 characters long.";
                flag2 = false;
            }
            else if (!hasUpper)
            {
                passwordTextBox.ForeColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                minimumCharacter.Text = "Password must include at least one uppercase letter.";
                flag2 = false;
            }
            else if (!hasLower)
            {
                passwordTextBox.ForeColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                minimumCharacter.Text = "Password must include at least one lowercase letter.";
                flag2 = false;
            }
            else if (!hasDigit)
            {
                passwordTextBox.ForeColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                minimumCharacter.Text = "Password must include at least one number.";
                flag2 = false;
            }
            else if (!hasSpecial)
            {
                passwordTextBox.ForeColor = Color.IndianRed;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.IndianRed;
                minimumCharacter.Text = "Password must include at least one special character.";
                flag2 = false;
            }
            else
            {
                // Strong Password
                passwordTextBox.ForeColor = Color.Green;
                minimumCharacter.Visible = true;
                minimumCharacter.ForeColor = Color.Green;
                minimumCharacter.Text = "Strong password.";
                flag2 = true;
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
