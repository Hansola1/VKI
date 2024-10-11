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
        public string info { get; set; }

        public ProductA1(string info)
        {
           this.info = A(info);
        }

        public string A(string info)
        {
            int answer = Convert.ToInt32(info) * 2;
            return answer.ToString();
        }

        public override AbstractProductA CreateProductA(string info)
        {
            return new ProductA1(info);
        }
    }
}
