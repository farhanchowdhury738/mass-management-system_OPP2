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
    public partial class PaymentHIstory: Form
    {
        string user;
        public PaymentHIstory(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void PaymentHIstory_Load(object sender, EventArgs e)
        {
            string studentemail = user;

            SqlCommand cmd = sda.GetQuery(@"
                                            SELECT paymentId, paymentDate, amount, phone, paymentMethod
                                            FROM Payment
                                            WHERE studentEmail = @studentEmail
                                        ");

            cmd.Parameters.AddWithValue("@studentEmail", studentemail);

            DataTable dt = sda.GetData(cmd);
            dataGridView1.DataSource = dt;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PremiumStudent ps = new PremiumStudent(user);
            ps.Show();
            this.Hide();
        }
    }
}
