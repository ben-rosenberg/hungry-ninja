using System;
using System.Collections.Generic;

namespace FoodSpace
{
    class Food
    {
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }

        public void Print()
        {
            Console.WriteLine($"Food: {Name}");
            Console.WriteLine($"Calories: {Calories}");
            string spicy = IsSpicy ? "Yes" : "No";
            string sweet = IsSweet ? "Yes" : "No";
            Console.WriteLine($"Spicy: {spicy}");
            Console.WriteLine($"Sweet: {sweet}");
        }

        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
    }

    class Buffet
    {
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("chicken", 300, false, false),
                new Food("salad", 200, false, false),
                new Food("cake", 450, false, true),
                new Food("garlic bread", 400, false, false),
                new Food("steak", 400, false, false),
                new Food("curry", 400, true, false),
                new Food("pecan pie", 500, false, true)
            };
        }

        public Food Serve()
        {
            Console.WriteLine("Serving...");
            Random random = new Random();
            int randomNumber = random.Next(0, Menu.Count);
            Food food = Menu[randomNumber];
            food.Print();
            return food;
        }

        public List<Food> Menu;
    }
}