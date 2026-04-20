using LogicLib;
using System.Xml.Linq;
using System.ComponentModel;
using System.ComponentModel.Design;


internal class Program
{
    private static void Main(string[] args)
    {
        Book b;
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<LogicLib.Reader>();

        int id = 0, ageBook = 0, countBook = 0;
        string author = "undifined", nameBook = "undifined", suname = "undifined", name = "undifined", group = "undifined";

        bool exit = true;
        do
        {
            Menu(ref exit, id, author, nameBook, ageBook, countBook, suname, name, group);
        } while (exit);

        void Menu(ref bool exit, int id, string author, string nameBook, int ageBook, int countBook, string surname, string name, string group)
        {
            Console.WriteLine("Меню:\n1 - Добавить книгу\n2 - Добавить читателя\n3 - Поиск книги\n4 - Выдать книгу\n5 - Выйти\n");
            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1: AddBook(id, author, nameBook, ageBook, countBook); break;
                case 2: AddReader(suname, name, group); break;
                case 3: SearchBook(books); break;
                case 4: PrintBook(books); break;
                case 5: Exit(); break;
            }
        }

        void AddBook(int id, string author, string nameBook, int ageBook, int countBook)
        {
            Book b;
            id = int.Parse(Console.ReadLine());
            author = Console.ReadLine();
            nameBook = Console.ReadLine();
            ageBook = int.Parse(Console.ReadLine());
            countBook = int.Parse(Console.ReadLine());

            b = new Book(id, author, nameBook, ageBook, countBook);
            books.Add(b);
            b = new Book(id, author, nameBook, ageBook, countBook);
            books.Add(b);
        }
        void AddReader(string suname, string name, string group)
        {
            Reader r;
            suname = Console.ReadLine();
            name = Console.ReadLine();
            group = Console.ReadLine();

            r = new Reader(suname, name, group);
            readers.Add(r);
        }

        void SearchBook(List<Book> books)
        {
            Console.WriteLine("По чему искать? По автору - 1/По артиклю - 2/По названию - 3");
            int sort;
            sort = int.Parse(Console.ReadLine());
            string write = Console.ReadLine();
            foreach (Book book in books)
            {
                switch (sort)
                {
                    case 1:
                        {
                            if (Convert.ToString(book.Id) == write)
                            {
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.NameBook}\nГод издания: {book.AgeBook}\nКоличество экземпляров: {book.CountBook}\n");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (book.Author == write)
                            {
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.NameBook}\nГод издания: {book.AgeBook}\nКоличество экземпляров: {book.CountBook}\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (book.NameBook == write)
                            {
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.NameBook}\nГод издания: {book.AgeBook}\nКоличество экземпляров: {book.CountBook}\n");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет похожих книг");
                            break;
                        }
                }
            }
        }


        void PrintBook(List<Book> books)
        {
            Console.WriteLine("Название книги");
            string s; s = Console.ReadLine();

            foreach (Book book in books)
            {
                if (s == book.NameBook)
                {
                    if (book.CountBook > 0)
                    {
                        book.CountBook--;
                        Console.WriteLine("Книга выдана");
                    }
                    else
                    {
                        Console.WriteLine("Книг нет");
                    }
                }
                else
                {
                    Console.WriteLine("Такой книги нет");
                }
            }
        }

        void Exit()
        {
            exit = false;
        }

    }
}