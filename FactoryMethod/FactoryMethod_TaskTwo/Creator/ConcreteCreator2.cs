using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskTwo
{
    public class ConcreteCreator2 : ConcreteCreator1
    {
        public ConcreteProduct2 FactoryMethod(string info)
        {
            return new ConcreteProduct2(info); 
        }

        public string AnOperation(string info)
        {
            var product = FactoryMethod(info);
            product.Transform();
            return product.GetInfo();
        }
    }
}
