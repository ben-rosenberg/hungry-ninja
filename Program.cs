using System;
using FoodSpace;
using People;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ben = new Ninja();
            Food food1 = buffet.Serve();
            Food food2 = buffet.Serve();
            Food food3 = buffet.Serve();
            Food food4 = buffet.Serve();
            Food food5 = buffet.Serve();
            ben.Eat(food1);
            ben.Eat(food2);
            ben.Eat(food3);
            ben.Eat(food4);
            ben.Eat(food5);
        }
    }
}
