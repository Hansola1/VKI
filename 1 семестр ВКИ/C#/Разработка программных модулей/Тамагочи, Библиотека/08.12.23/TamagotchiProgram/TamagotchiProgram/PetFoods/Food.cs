using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Pets;

namespace Tamagotchi.PetFoods
{
    public abstract class Food
    {
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }

        public Food (string name = default, int health = default)
        {
            Name = name;
            Health = health;
        }

    }
}
