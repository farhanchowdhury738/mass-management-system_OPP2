using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Model
{
    public class Meal
    {
        

        private string mealId;
        private string day;
        private string breakfast;
        private string breakfast_price;
        private string lunch;
        private string lunch_price;
        private string dinner;
        private string dinner_price;

        public Meal() { }

        public Meal(string mealId, string breakfast, string breakfast_price, string lunch, string lunch_price, string dinner, string dinner_price)
        {
            this.mealId = mealId;
            this.breakfast = breakfast;
            this.breakfast_price = breakfast_price;
            this.lunch = lunch;
            this.lunch_price = lunch_price;
            this.dinner = dinner;
            this.dinner_price = dinner_price;
        }

        public Meal(string mealId, string day, string breakfast, string breakfast_price, string lunch, string lunch_price, string dinner, string dinner_price)
        {
            this.mealId = mealId;
            this.day = day;
            this.breakfast = breakfast;
            this.breakfast_price = breakfast_price;
            this.lunch = lunch;
            this.lunch_price = lunch_price;
            this.dinner = dinner;
            this.dinner_price = dinner_price;
        }

        public string MealId { get => mealId; set => mealId = value; }
        public string Day { get => day; set => day = value; }
        public string Breakfast { get => breakfast; set => breakfast = value; }
        public string Breakfast_price { get => breakfast_price; set => breakfast_price = value; }
        public string Lunch { get => lunch; set => lunch = value; }
        public string Lunch_price { get => lunch_price; set => lunch_price = value; }
        public string Dinner { get => dinner; set => dinner = value; }
        public string Dinner_price { get => dinner_price; set => dinner_price = value; }
    }
}
