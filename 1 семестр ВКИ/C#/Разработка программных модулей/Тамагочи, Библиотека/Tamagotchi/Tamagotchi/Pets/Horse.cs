using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.foodPets;

namespace Tamagotchi.Animals
{
    internal class Horse : Pets
    {
        public Horse(string nikName = "UnDefault", string typeName = "UnDefault", int hunger = 20) : base(nikName, typeName, hunger)
        {
        }

        public override void Eat(Food food)
        {
            Console.WriteLine($"{NikName} поел (a) {food.type}. {food.energy} + к сытости");
            Hunger += food.energy;
        }

        public override void Say()
        {
            Console.WriteLine($"{NikName} Игого");
        }

        public override void Play()
        {
            Hunger -= 2;
            Console.WriteLine($"{NikName} Лошадь попрыгала, но немного проголодалась");
        }

        public override void Run()
        {
            Hunger -= 5;
            Console.WriteLine($"{NikName} Лошадь поела, но сильно проголодалась");
        }
    }
}
