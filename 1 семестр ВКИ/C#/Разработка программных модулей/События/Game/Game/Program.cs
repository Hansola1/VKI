using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            DangerMessage danger = new DangerMessage();

            Console.WriteLine("Если хотите ударить невинного человека 1 раз, то нажмите 1 \nЕсли хотите отпустить, то 0:");
            int hit = Convert.ToInt32(Console.ReadLine());

            if (hit == 1)
            {
                player.OnFight += danger.Message;
                player.fight();
         
            }
            else
            {
                Console.WriteLine("ПОКА :)");
            }
        }
    }
}