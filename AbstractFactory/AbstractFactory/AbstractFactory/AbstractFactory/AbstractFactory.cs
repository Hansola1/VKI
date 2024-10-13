using AbstractFactory_TaskOne.A;
using AbstractFactory_TaskOne.AbstractProduct;
using AbstractFactory_TaskOne.B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA(int value);
        public abstract AbstractProductB CreateProductB(int value);
    }
}
