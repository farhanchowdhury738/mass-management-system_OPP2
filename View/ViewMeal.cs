using ScholarsNest.Controler;
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
    public partial class ViewMeal: Form
    {
        string user;
        public ViewMeal(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ViewMeal_Load(object sender, EventArgs e)
        {
            MealController mc = new MealController();
            dataGridView1.DataSource = mc.GetAllMeal();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PremiumStudent ps = new PremiumStudent(user);
            ps.Show();
            this.Hide();
        }
    }
}
