using AbstractFactory_TaskOne.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override A.AbstractProductA CreateProductA(string info)
        {
            return new ProductA1();
            return new ProductA2();
        }

        public override B.AbstractProductB CreateProductB(string info)
        {
            return new ProductA1();
            return new ProductA2();
        }
    }
}
