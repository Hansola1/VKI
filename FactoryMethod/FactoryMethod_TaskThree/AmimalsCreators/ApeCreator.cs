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
        public string name { get; set; }
        public int idx { get; set; }

        public ApeCreator(int idx, string name)
        {
            this.name = name;
            this.idx = idx;
        }

        public override Animal CreateAnimal(int ind, string name)
        {
            // name = lion.name;
            if (ind == 0)
            {
                return new Gorilla(name);
            }
            else if (ind == 1)
            {
                return new Orangutan(name);
            }
            else if (ind == 2)
            {
                return new Chimpanze(name);
            }
            return new Gorilla(name);
        }
    }
}
