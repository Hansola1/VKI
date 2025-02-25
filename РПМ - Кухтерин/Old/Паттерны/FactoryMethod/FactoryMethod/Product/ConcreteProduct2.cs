using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskOne.Product
{
    public class ConcreteProduct2 : Product
    {
        public string info { get; set; }

        public ConcreteProduct2(string info)
        {
            this.info = info.ToUpper();
        }


        public override string GetInfo()
        {
            return info;
        }

        public override void Transform()
        {
            for (int i = 0; i < info.Length - 1; i++)
            {
                if (info[i] != '*') // подкинем две звездочки, если текущий символ не звездочка
                {
                    info = info.Insert(i + 1, "**");
                    i += 2; // Пропускаем добавленные звездочки
                }
            }
        }
    }
}
