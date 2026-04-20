using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_lib
{
    public class Reader
    {
        
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Group { get; set; }
            public List<Book> Books { get; set; }

            public Reader(string surname, string group, string name)
            {
                Surname = surname;
                Group = group;
                Books = new List<Book>();
                Name = name;
            }
    
            public override string ToString()
            {
                return $"\nФ.И.О.: {Surname}\n {Name}Номер группы: {Group}\nСписок книг: {Books}\n";
            }
        
    }
}
