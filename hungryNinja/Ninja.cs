using System;
using System.Collections.Generic;

namespace hungryNinja
{
    class Ninja 
    {
        private int CaloriesIntake;
        public List<Food> FoodHistory;
        public bool IsFull
        {
            get {return CaloriesIntake > 1200;}
        }
        
        // Constructor
        public Ninja()
        {
            CaloriesIntake = 0;
        }

        // public Ninja(int caloriesIntake)
        // {
        //     CaloriesIntake = caloriesIntake;
        // }

        public string Eat(Food food)
        {
            FoodHistory = new List<Food>();
            if(CaloriesIntake < 1200)
            {
                CaloriesIntake += food.Calories;
                FoodHistory.Add(food);
                return $"Name: {food.Name}; Spicy: {food.IsSpicy}; Sweet: {food.IsSweet}";
            }
            else
            {
                return "Ninja is Full";
            }
        }
    }
}