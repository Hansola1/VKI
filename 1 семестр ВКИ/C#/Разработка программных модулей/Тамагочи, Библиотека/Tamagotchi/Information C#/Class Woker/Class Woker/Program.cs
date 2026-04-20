using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Class_Woker
{
    internal class Program

    {
        public class Worker
        {
            public string name;
            public string surname;
            public int rate;
            public int days;

            public void GetFullName()
            {
                Console.WriteLine($"Фамилия сотрудника:{surname}\n Имя сотрудника: {name}");

            }
            public int GetSalary()
            {
                int many = rate * days;
                return many;
            }
        }

    }
}
