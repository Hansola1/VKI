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
        public string objA { get; set; }
        public string objB {  get; set; }
        public string info {  get; set; }

        public ProductB1(string info)
        {
            this.info = info;
            this.objB = info(objB);
            this.objA = info(objA);
        }

        public string obj(string info)
        {
            int answer = Convert.ToInt32(info);
            return answer.ToString();
        }

        public override AbstractProductB CreateProductB(string info)
        {
            return new ProductB1(info);
        }
    }
}
