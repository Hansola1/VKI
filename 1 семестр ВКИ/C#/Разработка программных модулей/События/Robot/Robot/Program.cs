using RobotMoveSW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Robot
{
    class Program
    { 
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            BackMess mess = new BackMess();
            robot.OnBack += WriteToFile; // назначить событие

            while (true)
            {
                Console.WriteLine($"Куда пойти роботу? Назад, вперед, влев, вправ?.\nНазад пишем в файл");
                string operand = Console.ReadLine();
                robot.MoveBack();

                switch (operand)
                {
                    case "Вперед":
                        robot.OnFront += mess.MessageFront;
                        robot.MoveFront();
                        break;
                    case "Вправ":
                        robot.OnRight += mess.MessageRight;
                        robot.MoveFront();
                        break;
                    case "Влев":
                        robot.OnLeft += mess.MessageLeft;
                        robot.MoveFront();
                        break;
                    case "Назад":
                        robot.OnBack += WriteToFile; 
                        break;
                    default:
                        Console.WriteLine("Неверный выбор...");
                        break;
                }
              // Console.ReadKey();
            }
        }

        //метод записи в файл
        private static void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Append, FileAccess.Write))) //G:/Robot/
            { 
                sw.WriteLine($"{DateTime.Now}. Робот движется назад");
            }
        }
    }
}