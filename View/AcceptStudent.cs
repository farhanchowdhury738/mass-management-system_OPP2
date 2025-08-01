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
    public partial class AcceptStudent: Form
    {
        string user;
        public AcceptStudent(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        SqlDbDataAccess sda = new SqlDbDataAccess();
        private void AcceptStudent_Load(object sender, EventArgs e)
        {
            string email = user;
            SqlCommand cmd = sda.GetQuery("SELECT id,password FROM AcceptedStudent where email=@email");
            DataTable dt = sda.GetData(cmd);
            dataGridView1.DataSource = dt;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // student dash boarad
            StudentDeshboard sd = new StudentDeshboard(user);
            sd.Show();
            this.Hide();

        }
    }
}
