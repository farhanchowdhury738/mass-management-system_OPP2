using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data;
using System.Data.SqlClient;

namespace ScholarsNest.Model
{

    
    public class Meals
    {

        SqlDbDataAccess sda = new SqlDbDataAccess();



        private string mealId;
        private string day;
        private string breakfast;
        private string breakfast_price;
        private string lunch;
        private string lunch_price;
        private string dinner;
        private string dinner_price;

        public void AddMeal(Meal s)
        {

            SqlCommand cmd = sda.GetQuery(
        "INSERT INTO Meal (mealId, day, breakfast, breakfast_price, lunch, lunch_price, dinner, dinner_price) " +
        "VALUES (@mealId, @day, @breakfast, @breakfast_price, @lunch, @lunch_price, @dinner, @dinner_price);");

            cmd.Parameters.AddWithValue("@mealId", s.MealId);
            cmd.Parameters.AddWithValue("@day", s.Day);
            cmd.Parameters.AddWithValue("@breakfast", s.Breakfast);
            cmd.Parameters.AddWithValue("@breakfast_price", s.Breakfast_price);
            cmd.Parameters.AddWithValue("@lunch", s.Lunch);
            cmd.Parameters.AddWithValue("@lunch_price", s.Lunch_price);
            cmd.Parameters.AddWithValue("@dinner", s.Dinner);
            cmd.Parameters.AddWithValue("@dinner_price", s.Dinner_price);

            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }


        public void UpdateMeal(Meal s)
        {
            SqlCommand cmd = sda.GetQuery("Update Meal set  breakfast=@breakfast, breakfast_price=@breakfast_price, lunch=@lunch, lunch_price=@lunch_price, dinner=@dinner, dinner_price=@dinner_price where mealId=@mealId;");
            //cmd.Parameters.AddWithValue("@day", s.Day);
            cmd.Parameters.AddWithValue("@mealId", s.MealId);
            cmd.Parameters.AddWithValue("@breakfast", s.Breakfast);
            cmd.Parameters.AddWithValue("@breakfast_price", s.Breakfast_price);
            cmd.Parameters.AddWithValue("@lunch", s.Lunch);
            cmd.Parameters.AddWithValue("@lunch_price", s.Lunch_price);
            cmd.Parameters.AddWithValue("@dinner", s.Dinner);
            cmd.Parameters.AddWithValue("@dinner_price", s.Dinner_price);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        public void DeleteMeal(string mealId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Meal WHERE mealId=@mealId;");
            cmd.Parameters.AddWithValue("@mealId", mealId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        


        public List<Meal> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Meal> MealList = new List<Meal>();

        //    private string mealId;
        //private string day;
        //private string breakfast;
        //private string breakfast_price;
        //private string lunch;
        //private string lunch_price;
        //private string dinner;
        //private string dinner_price;


            using (reader)
            {
                while (reader.Read())
                {
                    Meal p = new Meal();
                    p.MealId = reader.GetString(0);
                    p.Day = reader.GetString(1);
                    p.Breakfast = reader.GetString(2);
                    p.Breakfast_price = reader.GetString(3);
                    p.Lunch = reader.GetString(4);
                    p.Lunch_price = reader.GetString(5);
                    p.Dinner = reader.GetString(6);
                    p.Dinner_price = reader.GetString(7);

                    MealList.Add(p);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return MealList;
        }


        public List<Meal> GetAllMeal()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Meal;");
            cmd.CommandType = CommandType.Text;
            List<Meal> MealList = GetData(cmd);
            return MealList;
        }










    }
}
