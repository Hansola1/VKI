using System;
using Tamagotchi.Pets;
using Tamagotchi.PetFoods;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args, Cat cat)
        {
            Cat cat = new Cat { Hunger = 5 };
            cat.Meow();
            Food food = new Food { Health = 10 };
            DoMeal(cat, food); 

            static void DoMeal(Cat c, Food f)
            {
                c.Eat(f); 
            }
        }
    }

}