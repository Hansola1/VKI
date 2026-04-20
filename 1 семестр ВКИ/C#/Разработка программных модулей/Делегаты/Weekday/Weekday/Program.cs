using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    delegate string MyDelegateForDays(); 
    class Program 
    {
        static MyDelegateForDays DaysVoid(string day)
        {
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int index = Array.IndexOf(daysOfWeek, day);

            // Результат реализован через анонимный метод: 
            return delegate () 
            {
                if (index == 6)  
                {
                    return daysOfWeek[0];
                }
                if (index == 0)
                {
                    return daysOfWeek[1];
                }
                if (index == 1)
                {
                    return daysOfWeek[2];
                }
                if (index == 3)
                {
                    return daysOfWeek[4];
                }
                if (index == 4)
                {
                    return daysOfWeek[5];
                }
                if (index == 5)
                {
                    return daysOfWeek[6];
                }

                return daysOfWeek[index];
            };
        }


        static void Main()  
        {
            Console.WriteLine("Напишите день недели!");
            string day = Console.ReadLine();

            MyDelegateForDays nextDay = DaysVoid(day);  

            for (int i = 0; i < 5; i++)
            {
                Console.Write(nextDay() + " "); 
            }
        }
    }
}

