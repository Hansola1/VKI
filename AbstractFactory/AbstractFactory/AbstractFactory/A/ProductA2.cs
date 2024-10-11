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
        public string info { get; set; }

        public ProductA2(string info)
        {
            this.info = info;
        }

        public string A(string info)
        {
            string infoReplace = info.Replace(info, info);
            return infoReplace;
        }

        public override AbstractProductA CreateProductA(string info)
        {
            info = A(info);
            return new ProductA1(info);
        }
    }
}
