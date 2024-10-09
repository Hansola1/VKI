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

        public List<Animal> GetZoo(int[] inds, string[] names)
        {
            List<Animal> zoo = new List<Animal>();
            for (int i = 0; i < inds.Length; i++)
            {
                zoo.Add(CreateAnimal(inds[i], names[i]));
            }
            return zoo;
        }

            /*public Animal[] GetZoo(int[] inds, string [] names)
    {
        Animal[] animals = new Animal[inds.Length];


        for (int i = 0; i < inds.Length; i++)
        {
            animals[i] += CreateAnimal(inds[i], names[i]);
        }
        return animals;
    }*/

    }
}
