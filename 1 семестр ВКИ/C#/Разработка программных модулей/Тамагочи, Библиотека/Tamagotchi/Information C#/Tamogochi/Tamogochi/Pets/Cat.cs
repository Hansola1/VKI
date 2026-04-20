using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamogochi.Foods;

namespace Tamogochi.Pets
{
    internal class Cat:Pets
    {
        public string Name;
        public int Hunger;

        public Cat(string name, int hungry, int happy) : base(name, hungry, happy)
        {
            Name = name;
            Hunger = hungry;
        }

        public void Meow() 
        {
            Console.WriteLine("meow! ");
        }
        public void Eat(Food food)
        {

            Console.WriteLine($"{Name} ate {food.TypeFood} and gained {food.Energy}");
            //Console.WriteLine("Кот съела мясо!");
            Hungry++;
            Console.WriteLine("Голод увеличился на 1");
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is running");
           // Console.WriteLine("Кот побегал и проголодался");
            Hungry--;
            Console.WriteLine("Годол уменьшен на 1");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing");
            //Console.WriteLine("Вы поиграли с котом, он счастлив и голоден");
            Hungry--;
            Happy++;
            Console.WriteLine("Годол уменьшен на 1, счастье увеличено");
        }
    }
}
