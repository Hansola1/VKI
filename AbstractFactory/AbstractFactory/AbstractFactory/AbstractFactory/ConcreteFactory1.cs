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
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA(int value)
        {
            return new ProductA1(value);
        }


        public override AbstractProductB CreateProductB(int value)
        {
            return new ProductB1(value);
        }
    }
}
