using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamogochi.Pets
{
    internal class Dog:Pets
    {
        public Dog(string name, int hungry, int happy) : base(name, hungry, happy)
        {
        }

        public void Gaw()
        {
            Console.WriteLine("gaw! ");
        }

        public void Eat()
        {
            Console.WriteLine("Пес съела мясо!");
            Hungry++;
            Console.WriteLine("Голод увеличился на 1");
        }

        public void Run()
        {
            Console.WriteLine("Пес побегал и проголодался");
            Hungry--;
            Console.WriteLine("Годол уменьшен на 1");
        }

        public void Play()
        {
            Console.WriteLine("Вы поиграли с собакой, он счастлив и голоден");
            Hungry--;
            Happy++;
            Console.WriteLine("Годол уменьшен на 1, счастье увеличено");
        }
    }
}
