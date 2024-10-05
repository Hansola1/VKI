using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_TaskTwo
{
    public class ConcreteProduct1 
    {
        public string info;

        public ConcreteProduct1(string info)
        {
            this.info = info.ToLower();
        }

        public string GetInfo() // override 
        {
            return info;
        }

        public void Transform() //override 
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
