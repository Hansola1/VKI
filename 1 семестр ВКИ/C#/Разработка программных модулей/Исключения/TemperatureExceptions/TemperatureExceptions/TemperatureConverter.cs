using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureExceptions
{
    public class TemperatureConverter
    {
        public int Temperature { get; set; }
        public string InMeasure { get; set; }
        public string OutMeasure {  get; set; }

        public TemperatureConverter(int temperature, string inMeasure, string outMeasure)
        {
            Temperature = temperature;
            OutMeasure = outMeasure;
            InMeasure = inMeasure;
        }


        public void ConvertTemperature(int temperature, string inMeasure, string outMeasure) 
        {
            if (inMeasure != "celsius" && inMeasure != "fahrenheit" && inMeasure != "kelvin")
            {
                throw new InvalidTemperatureException("Неверное значение температуры");
                //оператор throw используется для создания объекта исключения
               // он указывает на место, где произошла ошибка *
            }

            else if (temperature <= -273) // 273 - абсолютный ноль
            {
                throw new ArgumentException("Передано несуществующие значение температуры");
            }



            switch (inMeasure.ToLower())
            {
                case "celsius":
                    if (outMeasure.ToLower() == "fahrenheit")
                    {
                        Console.WriteLine($"Результат конвертации {(temperature * 9 / 5) + 32}");
                    }
                    else if (outMeasure.ToLower() == "kelvin")
                    {
                        Console.WriteLine($"Результат конвертации {(temperature + 273)}");
                    }
                    else
                    {
                        Console.WriteLine($"Результат конвертации {temperature}");
                    }
                    break;

                case "fahrenheit":
                    if (outMeasure.ToLower() == "celsius")
                    {
                        Console.WriteLine($"Результат конвертации {(temperature - 32) * 5 / 9}");
                    }
                    else if (outMeasure.ToLower() == "kelvin")
                    {
                        Console.WriteLine($"Результат конвертации {(temperature + 459) * 5 / 9}");
                    }
                    else
                    {
                        Console.WriteLine($"Результат конвертации {temperature}");
                    }
                    break;

                case "kelvin":
                    if (outMeasure.ToLower() == "celsius")
                    {
                        Console.WriteLine($"Результат конвертации {temperature - 273}");
                    }
                    else if (outMeasure.ToLower() == "fahrenheit")
                    {
                        Console.WriteLine($"Результат конвертации {(temperature * 9 / 5) - 459}");
                    }
                    else
                    {
                        Console.WriteLine($"Результат конвертации {temperature}");
                    }
                    break;

                default:
                    {
                        return;
                    }
            }
        }       
    }
}
