using ScholarsNest.Model;
using ScholarsNest.View;
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

namespace ScholarsNest
{
    public partial class UpdateMeal: Form
    {
        string u;
        public UpdateMeal(string user)
        {
            InitializeComponent();
            this.u = user;
        }


        private void Back_Click(object sender, EventArgs e)
        {
            PremiumStudent sd = new PremiumStudent(u);
            this.Hide();
            sd.Show();
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        double totalPrice = 0;
        double bprice, lprice, dprice;
        int bcount, lcount, dcount;
        private void updateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            string input = updateDateTimePicker.Text;
            string result = input.Substring(0, input.IndexOf(","));
            string day = result;

            SqlCommand cmd = sda.GetQuery("SELECT * FROM Meal WHERE day = @day;");
            cmd.Parameters.AddWithValue("@day", day);



            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    bfoodLabel.Text = reader["breakfast"].ToString();
                    bpriceLabel.Text = reader["breakfast_price"].ToString();

                    double.TryParse(reader["breakfast_price"].ToString(), out bprice);

                }
            }


            using (SqlDataReader reader1 = cmd.ExecuteReader())
            {
                if (reader1.Read())
                {
                    lfoodLabel.Text = reader1["lunch"].ToString();
                    lpriceLabel.Text = reader1["lunch_price"].ToString();

                    double.TryParse(reader1["lunch_price"].ToString(), out lprice);

                }
            }


            using (SqlDataReader reader2 = cmd.ExecuteReader())
            {
                if (reader2.Read())
                {
                    dfoodLabel.Text = reader2["dinner"].ToString();
                    dpriceLabel.Text = reader2["dinner_price"].ToString();

                    double.TryParse(reader2["dinner_price"].ToString(), out dprice);

                }
            }



            cmd.Connection.Close();


        }

        double btotal = 0, ltotal = 0, ntotal = 0;

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (BreakfaastCount.Text == "" || LunchCount.Text == "" || DinnerCount.Text == "")
            {
                MessageBox.Show("Fill Quantity!");
            }
            else
            {
                
                // breakfast
                int.TryParse(BreakfaastCount.Text, out bcount);
                btotal += bprice * bcount;

                //lunch
                int.TryParse(LunchCount.Text, out lcount);
                ltotal += lprice * lcount;

                //dinner
                int.TryParse(DinnerCount.Text, out dcount);
                ntotal += dprice * dcount;



                totalPrice = btotal + ltotal + ntotal;
                totalbalanceLabel.Text = totalPrice.ToString("0.00") + " ৳";
                


                string studentemail = u;
                string date = updateDateTimePicker.Text;
                string breakprice = btotal.ToString();
                string lunchprice = ltotal.ToString();
                string nprice = ntotal.ToString();
                string total = totalPrice.ToString();


                totalPrice = 0;
                btotal = ltotal = ntotal = 0;

                // no mvc pattern follow
                try
                {
                    SqlCommand cmd = sda.GetQuery(@"INSERT INTO StudentMeal (studentEmail, mealDate, bprice, lprice, nprice, total) 
                                                VALUES (@studentEmail, @mealDate, @bprice, @lprice, @nprice, @total)");

                    cmd.Parameters.AddWithValue("@studentEmail", studentemail);
                    cmd.Parameters.AddWithValue("@mealDate", date);
                    cmd.Parameters.AddWithValue("@bprice", breakprice);
                    cmd.Parameters.AddWithValue("@lprice", lunchprice);
                    cmd.Parameters.AddWithValue("@nprice", nprice);
                    cmd.Parameters.AddWithValue("@total", total);

                    // Execute
                    cmd.Connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Meal information saved successfully!");
                        PremiumStudent ps = new PremiumStudent(u);
                        ps.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. No rows were inserted.");
                    }


                }
                catch(Exception exp)
                {
                    MessageBox.Show("Error: " + exp.Message);
                }






            }


        }
        


        private void DinnerCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dinner_Click(object sender, EventArgs e)
        {

        }

        private void LunchCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lunch_Click(object sender, EventArgs e)
        {

        }

        private void BreakfastCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountBreakfast_Click(object sender, EventArgs e)
        {

        }

        private void DateControl_Click(object sender, EventArgs e)
        {
            

        }

        private void YourOrder_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void dpriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void bpriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
