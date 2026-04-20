using Tamagotchi.PetFoods;
using Tamagotchi.Pets;

namespace Tamagotchi.Pets
{
    public class Cat : Pets
    {
        public void Meow()
        {
            Console.WriteLine("meow! ");
        }

        public override void Eat(Food f)
        {
            Console.WriteLine($"Cat eats apple{f.Name}. {f.Health} hp.\n");
        }

    }
}

    