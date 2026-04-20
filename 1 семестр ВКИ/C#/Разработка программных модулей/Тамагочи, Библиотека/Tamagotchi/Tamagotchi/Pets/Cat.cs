using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.foodPets;

namespace Tamagotchi.Animals
{
    internal class Cat : Pets
    {
        public Cat(string nikName = "UnDefault", string typeName = "UnDefault", int hunger = 10) : base(nikName, typeName, hunger)
        {

        }

        public override void Eat(Food food) 
        {
            Console.WriteLine($"{NikName} поел(a) {food.type}. {food.energy} + к сытость");
            Hunger += food.energy;
        }

        public override void Say()
        {
            Console.WriteLine($"{NikName} Мяу!");
        }
        public override void Play()
        {
            Hunger -= 2;
            Console.WriteLine($"{NikName} Кот поиграл, но немного проголодался");
        }
        public override void Run()
        {
            Hunger -= 5;
            Console.WriteLine($"{NikName} Кот побегал, но сильно проголодался");
        }

    }
}
