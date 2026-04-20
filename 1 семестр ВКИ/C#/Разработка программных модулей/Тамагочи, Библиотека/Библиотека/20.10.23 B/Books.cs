using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string NameBook { get; set; }
        public int AgeBook { get; set; }
        public int CountBook { get; set; }

        public Book(int id, string author, string nameBook, int ageBook, int countBook)
        {
            Id = id;
            Author = author;
            NameBook = nameBook;
            AgeBook = ageBook;
            CountBook = countBook;
        }

        public override string ToString()
        {
            return string.Format($"{Id} {Author}\n{NameBook}\n{AgeBook}\n{CountBook}");
        }
    }
}

