using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.foodPets;

namespace Tamagotchi.Animals
{
    internal abstract class Pets
    {
        public int Hunger { get; set; }
        public string TypeName { get; set; } 
        public string NikName { get; set; } 

        public Pets (string nikName = "UnDefault", string typeName = "UnDefault", int hunger = 10) 
        {
            Hunger = hunger;
            TypeName = typeName;
            NikName = nikName;
        }

        public abstract void Eat(Food food); 
        public abstract void Say();
        public abstract void Play();
        public abstract void Run();

    }
}
