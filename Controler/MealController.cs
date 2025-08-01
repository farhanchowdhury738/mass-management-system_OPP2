using ScholarsNest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsNest.Controler
{
    public class MealController
    {
        public void AddMeal(Meal s)
        {
            Meals cls = new Meals();
            cls.AddMeal(s);
        }

        public void UpdateMeal(Meal p)
        {
            Meals ps = new Meals();
            ps.UpdateMeal(p);
        }

        public void DeleteMeal(string email)
        {
            Meals ps = new Meals();
            ps.DeleteMeal(email);
        }


        public List<Meal> GetAllMeal()
        {
            Meals ps = new Meals();
            List<Meal> mealList = ps.GetAllMeal();
            return mealList;
        }
    }
}
