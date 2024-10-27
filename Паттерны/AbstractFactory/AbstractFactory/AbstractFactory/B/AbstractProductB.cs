using AbstractFactory_TaskOne.A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.B
{
    public abstract class AbstractProductB
    {
        protected string info;

        protected AbstractProductB(int value)
        {
            info = value.ToString();
        }

        public abstract void B(AbstractProductA productA);
        public abstract string GetInfo();
    }
}
