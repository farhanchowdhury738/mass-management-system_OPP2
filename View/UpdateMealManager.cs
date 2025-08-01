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
using ScholarsNest.Model;


namespace ScholarsNest.View
{
    public partial class UpdateMealManager: Form
    {
        public UpdateMealManager()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            this.Hide();
            m.Show();
        }

        private void UpdateMealManager_Load(object sender, EventArgs e)
        {
            UpdateMealManager umm = new UpdateMealManager();
            this.Hide();
            umm.Show();
        }

        private void UpdateMealManager_Load_1(object sender, EventArgs e)
        {
            MealController pc = new MealController();
            dataGridView1.DataSource = pc.GetAllMeal();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvr = dataGridView1.Rows[e.RowIndex];

                MealidText.Text = dvr.Cells[0].Value.ToString();
                dayText.Text = dvr.Cells[1].Value.ToString();
                BFood.Text = dvr.Cells[2].Value.ToString();
                BPrice.Text = dvr.Cells[3].Value.ToString();
                LFood.Text = dvr.Cells[4].Value.ToString();
                LPrice.Text = dvr.Cells[5].Value.ToString();
                DFood.Text = dvr.Cells[6].Value.ToString();
                DPrice.Text = dvr.Cells[7].Value.ToString();

                //MealidText.Enabled = false;
                
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MealidText.Text=="")
            {
                MessageBox.Show("Meal ID must be filled!!");
                return;
            }


            try
            {
                string mealId = MealidText.Text;

                MealController pc = new MealController();

                pc.DeleteMeal(mealId);

                MessageBox.Show("Meal Deleted Successflly");
                MealidText.Clear();
                dayText.Clear();
                BFood.Clear();
                BPrice.Clear();
                LFood.Clear();
                LPrice.Clear();
                DFood.Clear();
                DPrice.Clear();


                dataGridView1.DataSource = pc.GetAllMeal();
                dataGridView1.Refresh();

            }

            catch (Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MealidText.Clear();
            dayText.Clear();
            BFood.Clear();
            BPrice.Clear();
            LFood.Clear();
            LPrice.Clear();
            DFood.Clear();
            DPrice.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string mealId = MealidText.Text;
            string day = dayText.Text;
            string bfood = BFood.Text;
            string bprice = BPrice.Text;
            string lfood = LFood.Text;
            string lprice = LPrice.Text;
            string dfood = DFood.Text;
            string dprice = DPrice.Text;

            if (string.IsNullOrWhiteSpace(mealId) || string.IsNullOrWhiteSpace(day) ||
                string.IsNullOrWhiteSpace(bfood) || string.IsNullOrWhiteSpace(bprice) ||
                string.IsNullOrWhiteSpace(lfood) || string.IsNullOrWhiteSpace(lprice) ||
                string.IsNullOrWhiteSpace(dfood) || string.IsNullOrWhiteSpace(dprice))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                Meal m = new Meal(mealId, day,bfood, bprice, lfood, lprice, dfood, dprice);

                MealController mcontrol = new MealController();
                mcontrol.UpdateMeal(m);

                BFood.Clear();
                BPrice.Clear();
                LFood.Clear();
                LPrice.Clear();
                DFood.Clear();
                DPrice.Clear();

                MessageBox.Show("Meal Updated Successfully!");

                dataGridView1.DataSource = mcontrol.GetAllMeal();
                dataGridView1.Refresh();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string mealId = MealidText.Text;
            string day = dayText.Text;
            string bfood = BFood.Text;
            string bprice = BPrice.Text;
            string lfood = LFood.Text;
            string lprice = LPrice.Text;
            string dfood = DFood.Text;
            string dprice = DPrice.Text;

            // --- Validation ---
            if (string.IsNullOrWhiteSpace(mealId) || string.IsNullOrWhiteSpace(day) ||
                string.IsNullOrWhiteSpace(bfood) || string.IsNullOrWhiteSpace(bprice) ||
                string.IsNullOrWhiteSpace(lfood) || string.IsNullOrWhiteSpace(lprice) ||
                string.IsNullOrWhiteSpace(dfood) || string.IsNullOrWhiteSpace(dprice))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(bprice, out _) || !decimal.TryParse(lprice, out _) || !decimal.TryParse(dprice, out _))
            {
                MessageBox.Show("Please enter valid numeric values for prices.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Meal m = new Meal(mealId, day, bfood, bprice, lfood, lprice, dfood, dprice);

                MealController mcontrol = new MealController();
                mcontrol.AddMeal(m); ;

                MealidText.Clear();
                dayText.Clear();
                BFood.Clear();
                BPrice.Clear();
                LFood.Clear();
                LPrice.Clear();
                DFood.Clear();
                DPrice.Clear();
                MessageBox.Show("Meal Added Successfully!");

                dataGridView1.DataSource = mcontrol.GetAllMeal();
                dataGridView1.Refresh();
            }
            catch(Exception exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }
    }
    
}
