using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class MainClass
    {
        public void Main(string[] args)
        {
            Num firstNum = new Num(9);
            Num secondNum = new Num(1);
            Num thirdNum = new Num(90);
            firstNum.Add(secondNum).AddNum(thirdNum).Print();
        }
    }

    public class NumExtensions
    {
        public static int Add(Num left, Num right)
        {
            return new Num(left.Value + right.Value);
        }
    }

    public static class Num
    {
        public static int Value;
        public Num() => Value = value;

        public void Print()
        {
            Console.WriteLine(this.Value);
        }

        internal object Add(Num secondNum)
        {
            throw new NotImplementedException();
        }
    }
}

