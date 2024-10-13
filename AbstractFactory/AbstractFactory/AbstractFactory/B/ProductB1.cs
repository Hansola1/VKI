using AbstractFactory_TaskOne.A;
using AbstractFactory_TaskOne.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.B
{
    public class ProductB1 : AbstractProductB
    {
        public ProductB1(int value) : base(value) { }

        public override void B(AbstractProductA productA)
        {
            int numberA = int.Parse(productA.GetInfo());
            int numberB = int.Parse(info);
            info = (numberA + numberB).ToString();
        }

        public override string GetInfo() => info;
    }
}
