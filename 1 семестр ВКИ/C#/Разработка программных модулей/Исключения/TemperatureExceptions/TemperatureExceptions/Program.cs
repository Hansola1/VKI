using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TemperatureExceptions.TemperatureConverter; 

namespace TemperatureExceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Напишите температуру и единицу измерения Цельсия/Фаренгейт/Кельвин: \nЕдиница измерения на англиском!!!");
            int temperature = Convert.ToInt32(Console.ReadLine());
            string inMeasure = Console.ReadLine();

            Console.WriteLine("Напишите единицу измерения в которую необходимо конвертировать температуру:");
            string outMeasure = Console.ReadLine();


            TemperatureConverter TempConv = new TemperatureConverter(temperature, inMeasure, outMeasure); 
            try
            {       
                TempConv.ConvertTemperature(temperature, inMeasure, outMeasure);
            }

            catch (InvalidTemperatureException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
