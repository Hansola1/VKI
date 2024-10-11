using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.A
{
    public abstract class AbstractProductA
    {
        public abstract AbstractProductA CreateProductA(string info);
    }
}
