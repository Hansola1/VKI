using FactoryMethod_TaskThree.Animals;

namespace FactoryMethod_TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }


        private static void Test()
        {

            int[] inds = new int[3];
            int[] names = new int[3];

            for (int i = 0; i < inds.Length; i++)
            {
                //arr[i] = rand.Next(-100, 100);
            }
            for (int i = 0; i < names.Length; i++)
            {
                //arr[i] = rand.Next(-100, 100);
            }


        }

        private static void inputTest()
        {
            Lion myLion = new Lion("Leo");
            string info = myLion.GetInfo();

            Console.WriteLine(info);
        }
    }
}
