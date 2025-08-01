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
    public partial class PremiumStudent: Form
    {
        string u;
        SqlDbDataAccess sda = new SqlDbDataAccess();
        public PremiumStudent(string u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void PremiumStudent_Load(object sender, EventArgs e)
        {
            string email = u;
            string studentEmail = u;

            SqlCommand cmd = sda.GetQuery("SELECT name FROM Student WHERE email = @email;");
            cmd.Parameters.AddWithValue("@email", email);

            SqlCommand cmd2 = sda.GetQuery(@"SELECT SUM(CAST(total AS FLOAT)) AS TotalAmount FROM StudentMeal WHERE studentEmail = @studentEmail;");
            cmd2.Parameters.AddWithValue("@studentEmail", email);

            SqlCommand cmd3 = sda.GetQuery(@"SELECT SUM(CAST(amount AS FLOAT)) AS TotalPaid FROM Payment WHERE studentEmail = @studentEmail;");
            cmd3.Parameters.AddWithValue("@studentEmail", email);


            // student name print after login
            //  connection open before run
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
                    // nothing
                }
            }

            // student current balance print after login
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            using (SqlDataReader reader2 = cmd2.ExecuteReader())
            {
                if (reader2.Read())
                {
                    currentamountLabel.Text = reader2["TotalAmount"].ToString();
                    mealbalance.Text = reader2["TotalAmount"].ToString();

                }
                else
                {
                    // nothing
                }
            }

            // student deposite balance
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }

            using (SqlDataReader reader3 = cmd3.ExecuteReader())
            {
                if (reader3.Read())
                {
                    depositBalance.Text = reader3["TotalPaid"].ToString();
                    
                }
                else
                {
                    // nothing
                }
            }


            // conver price string to numerical 
            double totalMealPrice = 0;
            double totalDeposit = 0;

            double.TryParse(currentamountLabel.Text, out totalMealPrice);
            double.TryParse(depositBalance.Text, out totalDeposit);

            double currentPrice = totalDeposit - totalMealPrice;

            
            currentamountLabel.Text = currentPrice.ToString("0.00") + " ৳";



        }

        private void updatemealButton_Click(object sender, EventArgs e)
        {
            UpdateMeal um = new UpdateMeal(u);
            this.Hide();
            um.Show();
        }

        private void depositebalanceButton_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(u);
            this.Hide();
            deposit.Show();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void viewprofileButton_Click(object sender, EventArgs e)
        {

            PremiumViewProfileStudent pvps = new PremiumViewProfileStudent(u);
            pvps.Show();
            this.Hide();
        }

        private void complainButton_Click(object sender, EventArgs e)
        {
            StudentComplain stu = new StudentComplain(u);
            stu.Show();
            this.Hide();
        }

        private void studentIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewmealButton_Click(object sender, EventArgs e)
        {
            ViewMeal vm = new ViewMeal(u);
            vm.Show();
            this.Hide();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            PaymentHIstory ph = new PaymentHIstory(u);
            ph.Show();
            this.Hide();
        }
    }
}
