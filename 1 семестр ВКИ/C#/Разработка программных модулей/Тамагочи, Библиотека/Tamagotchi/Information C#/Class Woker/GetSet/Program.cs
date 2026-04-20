using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GetSet
{
    public class MainClass
    {
        public static void Main()
        {          
            var tree1 = new Tree("сосна", -6);
            var tree2 = new Tree("береза", 80);            
        }
    }

    class Tree
    {
        private string type;
        private int height;

        public string Type
        { get { return type; } set { type = value; } }
        public int Height
        { get { return height; } set { height = value; } }

        public Tree(string type, int height)
        {
            Type = type;
            Height = height;

            if (Height <= 0)
            {
                Height = 1;
                Console.WriteLine($"Вы создали дерево \"{Type}\" высотой {Height} см");
            }

        } 
    }
}
