using My_lib;
using static System.Reflection.Metadata.BlobBuilder;

namespace WinFormsLibrary
{
    public partial class FormLibrary : Form
    {

        private void InitializeBooks()
        {
            books.Add(new Book(1468, "Л.Н. Толстой", "Война и мир", 1867, 1));
            books.Add(new Book(1469, "Л.Н. Толстой", "Анна Каренина", 1877, 1));
            books.Add(new Book(1470, "Л.Н. Толстой", "Анна Каренина", 2023, 10));
        }
        private void InitializeReader()
        {
            readers.Add(new Reader("Иванов", "2207E2", "Иван"));
            readers.Add(new Reader("Петров", "2207A2", "Петр"));
            readers.Add(new Reader("Умер", "03.11.23", "Данн"));
        }
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<My_lib.Reader>();
        /// <summary>
        /// инициализация
        /// </summary>
        public FormLibrary()
        {
            InitializeComponent();
            InitializeBooks();
            InitializeReader();
            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem(book.Id.ToString());
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.PubYear.ToString());
                item.SubItems.Add(book.CountCopies.ToString());
                listViewBook.Items.Add(item);
            }
            foreach (Reader reader in readers)
            {
                ListViewItem item = new ListViewItem(reader.Name);
                item.SubItems.Add(reader.Surname);
                item.SubItems.Add(reader.Group);
                listViewReader.Items.Add(item);
            }

        }
        /// <summary>
        /// Выдача книги читателю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGet_Click(object sender, EventArgs e)
        {
            bool c = false;
            if (textBoxIdGet.Text != "" && textBoxGetReaderSurname.Text != "")
            {
                foreach (Reader reader in readers)
                {
                    if (textBoxGetReaderSurname.Text == reader.Surname)
                    {
                        foreach (Book book in books)
                        {

                            if (textBoxIdGet.Text == (book.Id).ToString())
                            {
                                if (book.CountCopies > 0)
                                {
                                    book.CountCopies--;
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
                        item.SubItems.Add(reader.Surname);
                        item.SubItems.Add(reader.Group);
                        string s = "";
                        foreach (Book book in reader.Books)
                        {

                            s += book.Title + " ";

                        }
                        item.SubItems.Add(s);
                        listViewReader.Items.Add(item);
                    }
                    listViewBook.Items.Clear();
                    foreach (Book book in books)
                    {
                        ListViewItem item = new ListViewItem(book.Id.ToString());
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Title);
                        item.SubItems.Add(book.PubYear.ToString());
                        item.SubItems.Add(book.CountCopies.ToString());
                        listViewBook.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }

            textBoxIdGet.Text = "";
            textBoxGetReaderSurname.Text = "";
        }
        /// <summary>
        /// Добавление книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookAddButton_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "" && textBoxAuthor.Text != "" && textBoxTitle.Text != "" && textBoxYear.Text != "" && textBoxCopies.Text != "")
            {
                books.Add(new Book(int.Parse(textBoxId.Text), textBoxAuthor.Text, textBoxTitle.Text, int.Parse(textBoxYear.Text), int.Parse(textBoxCopies.Text)));
                ListViewItem item = new ListViewItem(textBoxId.Text);
                item.SubItems.Add(textBoxAuthor.Text);
                item.SubItems.Add(textBoxTitle.Text);
                item.SubItems.Add(textBoxYear.Text);
                item.SubItems.Add(textBoxCopies.Text);
                listViewBook.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
        /// <summary>
        /// Добавление читателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddReader_Click(object sender, EventArgs e)
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
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
        /// <summary>
        /// Поиск книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
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

                        if (textBoxSearch.Text == book.Title)
                        {
                            labelSearch.Text += Convert.ToString(book);
                        }
                    }
                }
                textBoxSearch.Text = "";
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
        /// <summary>
        /// Условие, чтобы вводились только цифры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBoxIdGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxYearGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonId.Checked)
            {
                char number = e.KeyChar;

                if (!Char.IsDigit(number))
                {
                    e.Handled = true;
                }
            }
        }


    }
}