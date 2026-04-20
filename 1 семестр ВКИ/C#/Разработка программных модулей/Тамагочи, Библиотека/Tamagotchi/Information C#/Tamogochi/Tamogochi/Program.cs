using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tamogochi.Foods;
using Tamogochi.Pets;

namespace Tamogochi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Барсик", 10,10);
            Dog dog = new Dog("Шарик", 10, 10);
            Food food = new Food("яблоко", 2);

            DoMeal(cat, new Food("Fish"));
            cat.Meow();

            void DoMeal(Cat cat, Food food)
            {
                cat.Eat(food);
            }

            cat.Eat();
            cat.Run();
            cat.Play();

            dog.Gaw();
            dog.Eat();
            dog.Run();
            dog.Play();

        }
    }
}
