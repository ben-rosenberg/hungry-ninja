using System;
using System.Collections.Generic;
using FoodSpace;

namespace People
{
    class Ninja
    {
        public Ninja()
        {
            FoodHistory = new List<Food>();
            _CalorieIntake = 0;
        }

        public void Eat(Food item)
        {
            if (IsFull)
            {
                Console.WriteLine("Ninja is already full! He can't eat any more.");
                return;
            }

            _CalorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine("Eating...");
            item.Print();
        }

        public bool IsFull
        {
            get { return _CalorieIntake > 1200; }
        }

        public List<Food> FoodHistory;
        private int _CalorieIntake;
    }
}