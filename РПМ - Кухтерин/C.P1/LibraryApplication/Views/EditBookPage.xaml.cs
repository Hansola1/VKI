using LibraryApplication.DataBase;
using System.Windows;
using System.Windows.Controls;

namespace LibraryApplication.Views
{

    public partial class EditBookPage : Page
    {
        private BookController bookDB = new();

        public EditBookPage()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            string articleNumber = BookArticleNumber_TextBox.Text;
            string title = BookTitle_TextBox.Text;
            string genre = BookGenre_TextBox.Text;
            string description = BookDescription_TextBox.Text;
            string returnDate = ReturnDate_TextBox.Text;
            string issueDate = IssueDate_TextBox.Text;
            string status = BookStatus_TextBox.Text;
            string readerName = ReaderName_TextBox.Text;

            int? readerID = bookDB.GetReaderNameById(readerName);

            if (string.IsNullOrEmpty(articleNumber) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(issueDate) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(readerName))
            {
                MessageBox.Show("Поля необходимо заполнить");
            }
            else
            {
                bookDB.EditBook(articleNumber, title, genre, description, issueDate, returnDate, status, readerID);
                MessageBox.Show("Книга изменилась!");
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // MainFrame.Navigate(MainWindow());
            Application.Current.Shutdown();
        }
    }
}
