using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.Creator
{
    public class ConcreteCreator1 : Creator
    {
        public override Product.Product FactoryMethod(string info)
        {
            return new Product.ConcreteProduct1(info);
        }
    }
}
