using FactoryMethod_TaskThree.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskThree.AmimalsCreators
{
    public class CatCreator: AnimalCreator
    {

        public override Animal CreateAnimal(int ind, string name)
        {
            // name = lion.name;
            switch (ind)
            {
                case 0:
                    return new Lion(name);
                case 1:
                    return new Tiger(name);
                case 2:
                    return new Leopard(name);
                default:
                    throw new ArgumentException($"Нет индекса: {ind}");
            }
        }
    }
}
