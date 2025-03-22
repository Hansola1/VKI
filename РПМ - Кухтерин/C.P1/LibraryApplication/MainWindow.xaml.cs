using LibraryApplication.DataBase;
using LibraryApplication.Model;
using LibraryApplication.Views;
using System.Windows;
using System.Windows.Controls;

namespace LibraryApplication
{
    public partial class MainWindow : Window
    {
        private BookController bookDB = new();
        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
        }

        public void LoadBooks()
        {
            List<Books> listBooks = bookDB.GetBook();
            Books_DataGrid.ItemsSource = listBooks;
        }

        private void Find_TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string findTextBox = Find_TextBox.Text;

            if (string.IsNullOrEmpty(findTextBox))
            {
                LoadBooks();
            }
            else
            {
                FilterBooks(findTextBox);
            }
        }
        private void FilterBooks(string searchText)
        {
            List<Books> filteredBooks = bookDB.GetBook()
                .Where(book => book.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Books_DataGrid.ItemsSource = filteredBooks;
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedBooks = Books_DataGrid.SelectedItem as Books;
            if (selectedBooks != null)
            {
                string articleNumber = selectedBooks.ArticleNumber;
                bookDB.DeleteBook(articleNumber);
                MessageBox.Show("Книга удалена!");

                LoadBooks();
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления");
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddBookPage());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = Books_DataGrid.SelectedItem as Books;
            if (selectedBook != null)
            {
                EditBookPage editBookPage = new EditBookPage();
                editBookPage.BookArticleNumber_TextBox.Text = selectedBook.ArticleNumber;
                editBookPage.BookTitle_TextBox.Text = selectedBook.Title;
                editBookPage.BookGenre_TextBox.Text = selectedBook.Genre;
                editBookPage.BookDescription_TextBox.Text = selectedBook.Description;
                editBookPage.IssueDate_TextBox.Text = selectedBook.IssueDate;
                editBookPage.ReturnDate_TextBox.Text = selectedBook.ReturnDate;
                editBookPage.BookStatus_TextBox.Text = selectedBook.Status;

                MainFrame.Navigate(new EditBookPage());
            }
            else
            {
                MessageBox.Show("Выберите книгу для изменения");
            }
        }
    }
}