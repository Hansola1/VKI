using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskOne.Creator
{
    public abstract class Creator
    {
        public abstract Product.Product FactoryMethod(string info);  // фабричный метод

        public string AnOperation(string info)
        {
            Product.Product product = FactoryMethod(info);
            product.Transform();
            product.Transform();

            return product.GetInfo();
        }

    }
}
