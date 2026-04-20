using My_lib;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Book b;
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<My_lib.Reader>();
        int id =0;
        string author = "undifined";
        string title = "undifined";
        string surname = "undifined";
        string name = "undifined";
        string group = "undifined";
        int pubYear=0;
        int countCopies = 0;
        bool exit = true;
        do
        {


            Menu(ref exit, id, author, title, pubYear, countCopies, surname, name, group);
        } while (exit);
        void Menu(ref bool exit, int id, string author, string title, int pubYear,  int countCopies, string surname,string name,string group)
        {
            Console.WriteLine("Пункт меню:\n0-Добавить книгу\n1-Добавить читателя\n2-Поиск книги\n3-Выдать книгу\n4-Выход");
            int var = int.Parse(Console.ReadLine());
            switch (var)
            {
                case 0:
                    addBook(id, author, title, pubYear, countCopies);
                    break;
                case 1:
                    addReader(surname, name, group);
                    break;
                case 2:
                    Search(books);
                    break;
                case 3:
                    GetBook(books);
                    break;
                case 4:
                    Exit();
                    break;
            }
        }
        void addBook(int id, string author, string title, int pubYear, int countCopies)
        {

            Book b;
            id = int.Parse(Console.ReadLine());
            author = Console.ReadLine();
            title = Console.ReadLine();
            pubYear = int.Parse(Console.ReadLine());
            countCopies = int.Parse(Console.ReadLine());
            b = new Book(id, author, title, pubYear, countCopies);
            books.Add(b);
            b = new Book(id, author, title, pubYear, countCopies);
            books.Add(b);
        }
        void addReader(string surname, string name, string group)
        {
            Reader r;
            surname = Console.ReadLine();
            name = Console.ReadLine();
            group = Console.ReadLine();
            r = new Reader(surname, name, group);
            readers.Add(r);
        }
        void Search(List<Book> books)
        {
            Console.WriteLine("По чему искать? article =1/autor=2/title=3");
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
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.Title}\nГод издания: {book.PubYear}\nКоличество экземпляров: {book.CountCopies}\n");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (book.Author == write)
                            {
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.Title}\nГод издания: {book.PubYear}\nКоличество экземпляров: {book.CountCopies}\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (book.Title == write)
                            {
                                Console.WriteLine($"\nАртикул: {book.Id}\nАвтор: {book.Author}\nНазвание: {book.Title}\nГод издания: {book.PubYear}\nКоличество экземпляров: {book.CountCopies}\n");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Не вхожит в вожможные варианты");
                            break;
                        }
                }
            }
        }

        void GetBook(List<Book> books)
        {
            Console.WriteLine("Название книги");
            string s;
            s=Console.ReadLine();
            foreach (Book book in books)
            {
                if (s == book.Title)
                {
                    if (book.CountCopies > 0)
                    {
                        book.CountCopies--;
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