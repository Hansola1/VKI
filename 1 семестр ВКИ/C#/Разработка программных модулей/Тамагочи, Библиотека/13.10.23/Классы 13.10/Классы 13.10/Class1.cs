using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class1
{
    internal class Athlete
    {
        static string name;
        static string firstName; static string sport;
        static int age;
        internal Athlete(string name, string firstName, string sport, int age)
        {
            Name = name; FirstName = firstName;
            Sport = sport; Age = age;
        }
        public string Name { get { return name; } set { name = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string Sport { get { return sport; } set { sport = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return string.Format($"{Name} {FirstName}\n{Sport}\n{Age}");
            //return $"{Name} {FirstName}\n{Sport}\n{Age}";
            //return string.Format("{0} {1}\n{2}\n{3}",Name, FirstName, Sport, Age);
        }
    }
}
