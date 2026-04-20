using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LogicLib
{
    public class Reader
    {

        public string Suname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public List<Book> Books { get; set; }

        public Reader(string surname, string group, string name)
        {
            Suname = surname;
            Group = group;
            Books = new List<Book>();
            Name = name;
        }

        public override string ToString()
         {
            return $"\nФ.И.О.: {Suname}\n {Name}Номер группы: {Group}\nСписок книг: {Books}\n";
        }
    }
}
