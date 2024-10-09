using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.Creator
{
    public class ConcreteCreator2 : Creator
    {
        public override Product.Product FactoryMethod(string info)
        {
            return new Product.ConcreteProduct2(info);
        }
    }
}
