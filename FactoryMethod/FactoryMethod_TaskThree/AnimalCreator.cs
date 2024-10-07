using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskThree
{
    public abstract class AnimalCreator 
    {
        public abstract Animal CreateAnimal(int ind, string name);  

        public Animal[] GetZoo(int[] inds, string [] names)
        {
            Animal[] animals = new Animal[inds.Length];


            for (int i = 0; i < inds.Length; i++)
            {
                animals[i] += CreateAnimal(inds[i], names[i]);
            }
            return animals;
        }

    }
}
