using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_TaskOne.A
{
    public abstract class AbstractProductA
    {
        protected string info;

        protected AbstractProductA(int value)
        {
            info = value.ToString();
        }

        public abstract void A();
        public abstract string GetInfo();
    }
}
