using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tamogochi.Foods
{
    internal class Food
    {
        public string TypeFood { get; set; }
        public int Energy { get; set; }


        public Food(string typeFood = "default", int energy = default)
        {
            TypeFood = typeFood;
            Energy = energy;
  
        }

    }
}
