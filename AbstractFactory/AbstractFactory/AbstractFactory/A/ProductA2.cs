using AbstractFactory_TaskOne.A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.AbstractProduct
{
    public class ProductA2 : AbstractProductA
    {
        public ProductA2(int value) : base(value) { }

        public override void A()
        {
            info += info; // Удваиваем строку
        }

        public override string GetInfo() => info;
    }
}
