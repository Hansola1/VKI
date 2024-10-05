using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskOne.Product
{
    public class ConcreteProduct1 : Product
    {
        public string info;

        public ConcreteProduct1(string info)
        {
            this.info = info.ToLower();
        }



        public override string GetInfo()
        {
            return info;
        }

        public override void Transform()
        {
            for (int i = 0; i < info.Length - 1; i++)
            {
                if (info[i] != ' ')
                {
                    info = info.Insert(i + 1, " ");
                    i++; // Пропускаем добавленный пробел
                }
            }
        }
    }

}
