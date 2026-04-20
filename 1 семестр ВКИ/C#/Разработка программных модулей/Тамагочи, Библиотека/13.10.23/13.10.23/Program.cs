using Class1;
using System.Drawing;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Athlete athlete = new Athlete("Ivanov", "Ivan", "gymnastics", "14");
        int size = Convert.ToInt32(Console.ReadLine()); Athlete[] athletes = new Athlete[size];
        /*string name = "";   string firstName = ""; string sport = ""; */
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Информаия {0}:", i + 1);
            Console.WriteLine("Имя:"); string name = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Спорт:"); string sport = Console.ReadLine();
            Console.WriteLine("Age:");

            int age = Convert.ToInt32(Console.ReadLine());
            athletes[i] = new Athlete(name, firstName, sport, age);

            Console.WriteLine("----------\n");
        }
        Search();

        void Search()
        {
            for (int i = 0; i < athletes.Length; i++)
            {
                if (athletes[i].Sport == "gymnastics" && athletes[i].Age < 20)
                {
                    Console.WriteLine(athletes[i].ToString());   //continue;
                }
            }
        }
    }

}


//Athlete.ToString ();
