using Biblio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace Biblio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeBooks();
            ListBooks.ItemsSource = books;
        }

        private void InitializeBooks()
        {
            books.Add(new Book(1468, "Л.Н. Толстой", "Война и мир", 1867, 1));
            books.Add(new Book(1469, "Л.Н. Толстой", "Анна каренина", 1877, 1));
            books.Add(new Book(1470, "Л.Н. Толстой", "Анна каренина", 2023, 10));
        }

        private bool SearchBook(ref Book book)
        {
            foreach (var item in books)
            {
                if (item.Id == book.Id && item.Author == book.Author
                    && item.Title == book.Title && item.PubYear == book.PubYear)
                {
                    book = item;
                    return true;
                }
            }
            return false;
        }
        public void NewBookClick(object sender, RoutedEventArgs e)
        {
            string autor = NewBookAuthor.Text;
            string title = NewBookTitle.Text;
            bool idbool = int.TryParse(NewBookId.Text, out int art);
            bool yrarbool = int.TryParse(NewBookPubYear.Text, out int year);
            bool countbool = int.TryParse(NewBookCountCopies.Text, out int count);
            if (!idbool || !yrarbool || !countbool
                || autor == string.Empty || title == string.Empty)
            {
                NewBookId.Text = string.Empty;
                NewBookTitle.Text = string.Empty;
                NewBookAuthor.Text = string.Empty;
                NewBookPubYear.Text = string.Empty;
                NewBookCountCopies.Text = string.Empty;
                AddNewBookTextBlokc.Text = "Ошибка ввода";
            }
            else
            {
                Book book = new Book(art, autor, title, year, count);

                if (SearchBook(ref book))
                {
                    book.CountCopies += count;
                    AddNewBookTextBlokc.Text = "Количество копий увеличено" + book.ToString();
                }
                else
                {
                    books.Add(book);
                    AddNewBookTextBlokc.Text = "Книга добавлена в каталог" + book.ToString();

                }
                ListBooks.Items.Refresh();
            }
        }
        public void SearchBooksClick(object sender, RoutedEventArgs e)
        {
            Book book = null;
            TextBlock searchBlock = (TextBlock)Choose.SelectedItem;
            switch (searchBlock.Text)
            {
                case "Артикул":
                    if (!int.TryParse(FindBookInput.Text, out int request))
                    {
                        BookInfoTextBlokc.Text = "Введены некоректные данные";
                        return;
                    }
                    book = books.Find(x => x.Id == request);
                    break;

                case "Автор":
                    book = books.Find(x => x.Author == FindBookInput.Text);
                    break;

                case "Название":
                    book = books.Find(x => x.Title == FindBookInput.Text);
                    break;
            }

            BookInfoTextBlokc.Text = book is null ? "Такой элемент не существует"
                : book.ToString();

        }


    }
}
