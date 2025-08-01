using Guna.UI2.AnimatorNS;
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
    public partial class Deposit : Form
    {
        string user;
        public Deposit(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PremiumStudent ps = new PremiumStudent(user);
            ps.Show();
            this.Hide();
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string studenemail = user;
            string date = paymentdateTimePicker.Text;
            string amount = amountTextBox.Text;
            string phone = phoneTextBox.Text;

            string paymentMethod = " ";
            if(bkashRadioButton.Checked)
            {
                paymentMethod = bkashRadioButton.Text;
            }
            else if (nogodRadioButton.Checked)
            {
                paymentMethod = nogodRadioButton.Text;
            }
            else if (roketRadioButton.Checked)
            {
                paymentMethod = roketRadioButton.Text;
            }
            else if (upayRadioButton.Checked)
            {
                paymentMethod = upayRadioButton.Text;
            }

            if (amountTextBox.Text == "" ||
                phoneTextBox.Text == "" ||
                phone.Length < 10 ||
                paymentMethod == "")
            {
                MessageBox.Show("Please enter a valid amount, phone number (11 digits), and select a payment method.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand cmd = sda.GetQuery(@"INSERT INTO Payment (studentEmail, paymentDate, amount, phone, paymentMethod) VALUES 
                                                (@studentEmail, @paymentDate, @amount, @phone, @paymentMethod)");

                cmd.Parameters.AddWithValue("@studentEmail", studenemail);
                cmd.Parameters.AddWithValue("@paymentDate", date);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                // Open connection before executing
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment recorded successfully!");
                    amountTextBox.Clear();
                    phoneTextBox.Clear();
                    paymentdateTimePicker.Value = DateTime.Now;
                    bkashRadioButton.Checked = false;
                    nogodRadioButton.Checked = false;
                    roketRadioButton.Checked = false;
                    upayRadioButton.Checked = false;

                    PremiumStudent ps = new PremiumStudent(user);
                    ps.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Failed to record payment.");
                }

            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }


        }
        bool flag = false;
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            string phone = phoneTextBox.Text;

            // Check each character: Must be >= '0' and <= '9'
            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                {
                    phoneTextBox.ForeColor = Color.Red;
                    invalidPhoneLabel.Visible = true;
                    invalidPhoneLabel.Text = "Only numbers are allowed.";
                    tickPicture2.Visible = false;
                    crossPicture2.Visible = true;
                    flag = false;

                    // Remove invalid characters
                    phoneTextBox.Text = new string(phone.Where(ch => ch >= '0' && ch <= '9').ToArray());
                    phoneTextBox.SelectionStart = phoneTextBox.Text.Length;
                    return;
                }
            }

            // Check if phone number is exactly 11 characters
            if (phone.Length != 11)
            {
                phoneTextBox.ForeColor = Color.Red;
                invalidPhoneLabel.Visible = true;
                invalidPhoneLabel.Text = "Phone number must be exactly 11 digits.";
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                return;
            }

            // Check if phone number starts with '01'
            if (phone[0] != '0' || phone[1] != '1')
            {
                phoneTextBox.ForeColor = Color.Red;
                invalidPhoneLabel.Visible = true;
                invalidPhoneLabel.Text = "Phone number must start with '01'.";
                tickPicture2.Visible = false;
                crossPicture2.Visible = true;
                flag = false;
                return;
            }

            // If valid
            phoneTextBox.ForeColor = Color.Green;
            invalidPhoneLabel.Visible = false;
            tickPicture2.Visible = true;
            crossPicture2.Visible = false;
            flag = true;
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            string amount = amountTextBox.Text;
            // Remove invalid characters
            amountTextBox.Text = new string(amount.Where(ch => ch >= '0' && ch <= '9').ToArray());
            amountTextBox.SelectionStart = amountTextBox.Text.Length;
            return;
        }
    }
}
