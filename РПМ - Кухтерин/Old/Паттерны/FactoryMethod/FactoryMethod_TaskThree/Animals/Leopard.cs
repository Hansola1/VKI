using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskThree.Animals
{
    public class Leopard: Animal
    {
        public string name { get; set; }

        public Leopard(string name)
        {
            this.name = name;
        }

        public override string GetInfo()
        {
            return $"{nameof(Lion)} {name}";
        }
    }
}
