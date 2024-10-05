using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskTwo
{
    public class ConcreteCreator1
    {
        public ConcreteProduct1 FactoryMethod(string info)
        {
            return new ConcreteProduct1(info); // Создает объект ConcreteProduct1
        }

        public string AnOperation(string info)
        {
            var product = FactoryMethod(info);
            product.Transform();
            return product.GetInfo();
        }
    }
}
