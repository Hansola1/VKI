using LogicLib;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibApp
{
    public partial class Menu : Form
    {
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<LogicLib.Reader>();
        private void InitializeBooks()
        {
            /* books.Add(new Book(1468, "Л.Н. Толстой", "Война и мир", 1867, 1));
             books.Add(new Book(1469, "Л.Н. Толстой", "Анна Каренина", 1877, 1));
             books.Add(new Book(1470, "Л.Н. Толстой", "Анна Каренина", 2023, 10)); */
        }

        private void InitializeReader()
        {
            readers.Add(new Reader("Иванов", "2207E2", "Иван"));
            readers.Add(new Reader("Петров", "2207A2", "Петр"));
            readers.Add(new Reader("Умер", "03.11.23", "Данн"));
        }

        public Menu()
        {
            InitializeComponent();
            InitializeBooks();
            InitializeReader();
            dataGridViewBooks.DataSource = books;

            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem(book.Id.ToString());
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.NameBook);
                item.SubItems.Add(book.AgeBook.ToString());
                item.SubItems.Add(book.CountBook.ToString());
                listViewBook.Items.Add(item);
            }
            foreach (Reader reader in readers)
            {
                ListViewItem item = new ListViewItem(reader.Name);
                item.SubItems.Add(reader.Suname);
                item.SubItems.Add(reader.Group);
                listViewReader.Items.Add(item);
            }
        }

        private void buttonGet(object sender, EventArgs e)
        {
            bool c = false;
            if (textBoxId.Text != "" && textBoxGetReaderSurname.Text != "")
            {
                foreach (Reader reader in readers)
                {
                    if (textBoxGetReaderSurname.Text == reader.Suname)
                    {
                        foreach (Book book in books)
                        {

                            if (textBoxId.Text == (book.Id).ToString())
                            {
                                if (book.CountBook > 0)
                                {
                                    book.CountBook--;
                                    reader.Books.Add(book);
                                    labelGet.Text = "Книга выдана";
                                    c = true;
                                    break;
                                }
                                else
                                {
                                    labelGet.Text = "Книг нет";
                                }
                            }
                            else
                            {
                                labelGet.Text = "Такой книги нет";
                            }
                        }
                        break;
                    }
                    else
                    {
                        labelGet.Text = "Такого читателя нет";
                    }
                }
                if (c)
                {
                    listViewReader.Items.Clear();
                    foreach (Reader reader in readers)
                    {

                        ListViewItem item = new ListViewItem(reader.Name);
                        item.SubItems.Add(reader.Suname);
                        item.SubItems.Add(reader.Group);
                        string s = "";
                        foreach (Book book in reader.Books)
                        {
                            s += book.NameBook + " ";
                        }
                        item.SubItems.Add(s);
                        listViewReader.Items.Add(item);
                    }
                    listViewBook.Items.Clear();
                    foreach (Book book in books)
                    {
                        ListViewItem item = new ListViewItem(book.Id.ToString());
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.NameBook);
                        item.SubItems.Add(book.AgeBook.ToString());
                        item.SubItems.Add(book.CountBook.ToString());
                        listViewBook.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }

            textBoxId.Text = "";
            textBoxGetReaderSurname.Text = "";
        }


        private void AddBookClick(object sender, EventArgs e)
        {
            if (IdBookTextBox.Text != "" && AuthorTextBox.Text != "" && NameBookTextBox.Text != "" && AgeBookTextBox.Text != "" && QuantityBookTextBox.Text != "")
            {
                books.Add(new Book(int.Parse(IdBookTextBox.Text), AuthorTextBox.Text, NameBookTextBox.Text, int.Parse(AgeBookTextBox.Text), int.Parse(QuantityBookTextBox.Text)));
                ListViewItem item = new ListViewItem(IdBookTextBox.Text);
                item.SubItems.Add(AuthorTextBox.Text);
                item.SubItems.Add(NameBookTextBox.Text);
                item.SubItems.Add(AgeBookTextBox.Text);
                item.SubItems.Add(QuantityBookTextBox.Text);
                listViewBook.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Выберите один из вариантов", "Ошибка",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void AddReaderClick(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxGroup.Text != "")
            {
                readers.Add(new Reader(textBoxName.Text, textBoxGroup.Text, textBoxSurname.Text));
                ListViewItem item = new ListViewItem(textBoxName.Text);
                item.SubItems.Add(textBoxSurname.Text);
                item.SubItems.Add(textBoxGroup.Text);
                listViewReader.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Выберите один из вариантов", "Ошибка",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void DightKey(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void SearchBookClick(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                labelSearch.Text = " ";
                foreach (Book book in books)
                {
                    if (radioButtonId.Checked)
                    {

                        if (textBoxSearch.Text == Convert.ToString(book.Id))
                        {

                            labelSearch.Text = Convert.ToString(book);
                        }
                    }
                    else if (radioButtonAuthor.Checked)
                    {

                        if (textBoxSearch.Text == book.Author)
                        {

                            labelSearch.Text += Convert.ToString(book);
                        }
                    }
                    else if (radioButtonTitle.Checked)
                    {

                        if (textBoxSearch.Text == book.NameBook)
                        {
                            labelSearch.Text += Convert.ToString(book);
                        }
                    }
                }
                textBoxSearch.Text = "";
            }
            else
            {
                MessageBox.Show("Должно быть заполнено");
            }

        }
    }
}
