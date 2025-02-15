using FactoryMethod_TaskThree.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskThree.AmimalsCreators
{
    public class ApeCreator: AnimalCreator
    {
        public override Animal CreateAnimal(int ind, string name)
        {
            switch (ind)
            {
                case 0:
                    return new Gorilla(name);
                case 1:
                    return new Orangutan(name);
                case 2:
                    return new Chimpanze(name);
                default:
                    throw new ArgumentException($"Invalid index: {ind}");
            }
        }
    }
}
