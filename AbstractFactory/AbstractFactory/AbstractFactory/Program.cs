using AbstractFactory_TaskOne.A;
using AbstractFactory_TaskOne.AbstractFactory;
using AbstractFactory_TaskOne.B;

namespace AbstractFactory_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Random random = new Random();
            int NF = random.Next(0, 2);

            int NA, NB;
            string S = "AB";

            AbstractFactory f;
            AbstractProductA pa;
            AbstractProductB pb;

            if (NF == 1)
            {

            }
            else if (NF == 2)
            {

            }
        }
    }
}