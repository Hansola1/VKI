using AbstractFactory_TaskOne.A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.AbstractProduct
{
    public class ProductA1: AbstractProductA
    {
        public ProductA1(int value) : base(value) { }


        public override void A()
        {
            int number = int.Parse(info);
            number *= 2;
            info = number.ToString();
        }

        public override string GetInfo() => info; // записываем значение в свойство
    }
}
