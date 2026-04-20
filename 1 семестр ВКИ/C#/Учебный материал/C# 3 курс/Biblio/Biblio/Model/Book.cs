using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model
{
 
        public class Book
        {
            public int Id { get; set; }
            public string Author { get; set; }
            public string Title { get; set; }
            public int PubYear { get; set; }
            public int CountCopies { get; set; }
            public Book(int id, string author, string title, int pubYear, int countCopies)
            {
                Id = id;
                Author = author;
                Title = title;
                PubYear = pubYear;
                CountCopies = countCopies;
            }

            public override string ToString()
            {
                return $"\nАртикул: {Id}\nАвтор: {Author}\nНазвание: {Title}\nГод Издания:{PubYear}\nКоличество экземляров{CountCopies}\n";

            }
        }
    }
