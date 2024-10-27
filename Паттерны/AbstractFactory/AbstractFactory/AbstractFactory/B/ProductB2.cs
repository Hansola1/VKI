using AbstractFactory_TaskOne.A;
using AbstractFactory_TaskOne.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.B
{
    public class ProductB2 : AbstractProductB
    {
        public ProductB2(int value) : base(value) { }

        public override void B(AbstractProductA productA)
        {
            info += productA.GetInfo(); 
        }

        public override string GetInfo() => info;
    }
}
