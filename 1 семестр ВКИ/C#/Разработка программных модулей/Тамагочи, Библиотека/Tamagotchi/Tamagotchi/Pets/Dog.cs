using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.foodPets;

namespace Tamagotchi.Animals
{
    internal class Dog : Pets
    {
        public Dog(string nikName = "UnDefault", string typeName = "UnDefault", int hunger = 10) : base(nikName, typeName, hunger)
        {

        }

        public override void Eat(Food food)
        {
            Console.WriteLine($"{NikName} поел(a) {food.type}. {food.energy} + к сытости");
            Hunger += food.energy;
        }

        public override void Say()
        {
            Console.WriteLine($"{NikName} Гав!");
        }

        public override void Play()
        {
            Hunger -= 2;
            Console.WriteLine($"{NikName} Пес поиграл с мячом, но он немного проголодался");
        }

        public override void Run()
        {
            Hunger -= 5;
            Console.WriteLine($"{NikName} Пес побегал, но он сильно проголодался");
        }
    }
}
