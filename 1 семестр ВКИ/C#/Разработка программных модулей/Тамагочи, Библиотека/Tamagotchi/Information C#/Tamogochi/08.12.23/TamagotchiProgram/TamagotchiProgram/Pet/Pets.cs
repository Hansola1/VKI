using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.PetFoods;

namespace Tamagotchi.Pets
{
    public abstract class Pets
    {
        public abstract int Hunger { get; set; }
        public abstract string NikName { get; set; }


        public Pets(string name = "default", int hunger = 100)
        {
            Hunger = hunger;
            NikName = name;
        }

        public abstract void Eat(Food food);
        public abstract void Say();
    }
}
