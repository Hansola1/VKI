namespace LibApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listViewBook = new ListView();
            dataGridViewBooks = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            booksBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            button1 = new Button();
            QuantityBookTextBox = new TextBox();
            AgeBookTextBox = new TextBox();
            NameBookTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            IdBookTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            radioButtonTitle = new RadioButton();
            radioButtonAuthor = new RadioButton();
            radioButtonId = new RadioButton();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            SearchBook = new Button();
            tabPage4 = new TabPage();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            sunameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerBindingSource2 = new BindingSource(components);
            listViewReader = new ListView();
            tabPage5 = new TabPage();
            textBoxSurname = new TextBox();
            label9 = new Label();
            button3 = new Button();
            textBoxGroup = new TextBox();
            textBoxName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tabPage6 = new TabPage();
            labelGet = new Label();
            button4 = new Button();
            textBoxId = new TextBox();
            label11 = new Label();
            textBoxGetReaderSurname = new TextBox();
            label10 = new Label();
            readerBindingSource1 = new BindingSource(components);
            readerBindingSource = new BindingSource(components);
            booksBindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource2).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(12, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 430);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewBook);
            tabPage1.Controls.Add(dataGridViewBooks);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(782, 402);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Каталог книг";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewBook
            // 
            listViewBook.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewBook.Location = new Point(-5, 22);
            listViewBook.Margin = new Padding(2, 2, 2, 2);
            listViewBook.Name = "listViewBook";
            listViewBook.Size = new Size(771, 370);
            listViewBook.TabIndex = 2;
            listViewBook.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, nameBookDataGridViewTextBoxColumn, ageBookDataGridViewTextBoxColumn, countBookDataGridViewTextBoxColumn });
            dataGridViewBooks.DataSource = booksBindingSource;
            dataGridViewBooks.Location = new Point(0, 0);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 25;
            dataGridViewBooks.Size = new Size(765, 391);
            dataGridViewBooks.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            nameBookDataGridViewTextBoxColumn.HeaderText = "NameBook";
            nameBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            nameBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageBookDataGridViewTextBoxColumn
            // 
            ageBookDataGridViewTextBoxColumn.DataPropertyName = "AgeBook";
            ageBookDataGridViewTextBoxColumn.HeaderText = "AgeBook";
            ageBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageBookDataGridViewTextBoxColumn.Name = "ageBookDataGridViewTextBoxColumn";
            ageBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // countBookDataGridViewTextBoxColumn
            // 
            countBookDataGridViewTextBoxColumn.DataPropertyName = "CountBook";
            countBookDataGridViewTextBoxColumn.HeaderText = "CountBook";
            countBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            countBookDataGridViewTextBoxColumn.Name = "countBookDataGridViewTextBoxColumn";
            countBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // booksBindingSource
            // 
            booksBindingSource.DataSource = typeof(LogicLib.Book);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(QuantityBookTextBox);
            tabPage2.Controls.Add(AgeBookTextBox);
            tabPage2.Controls.Add(NameBookTextBox);
            tabPage2.Controls.Add(AuthorTextBox);
            tabPage2.Controls.Add(IdBookTextBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(782, 402);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить книгу";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(625, 26);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddBookClick;
            // 
            // QuantityBookTextBox
            // 
            QuantityBookTextBox.Location = new Point(548, 28);
            QuantityBookTextBox.Name = "QuantityBookTextBox";
            QuantityBookTextBox.Size = new Size(72, 23);
            QuantityBookTextBox.TabIndex = 9;
            QuantityBookTextBox.KeyPress += DightKey;
            // 
            // AgeBookTextBox
            // 
            AgeBookTextBox.Location = new Point(450, 28);
            AgeBookTextBox.Name = "AgeBookTextBox";
            AgeBookTextBox.Size = new Size(75, 23);
            AgeBookTextBox.TabIndex = 8;
            AgeBookTextBox.KeyPress += DightKey;
            // 
            // NameBookTextBox
            // 
            NameBookTextBox.Location = new Point(219, 28);
            NameBookTextBox.Name = "NameBookTextBox";
            NameBookTextBox.Size = new Size(212, 23);
            NameBookTextBox.TabIndex = 7;
            NameBookTextBox.KeyPress += DightKey;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(91, 28);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(113, 23);
            AuthorTextBox.TabIndex = 6;
            AuthorTextBox.KeyPress += DightKey;
            // 
            // IdBookTextBox
            // 
            IdBookTextBox.Location = new Point(17, 28);
            IdBookTextBox.Name = "IdBookTextBox";
            IdBookTextBox.Size = new Size(55, 23);
            IdBookTextBox.TabIndex = 5;
            IdBookTextBox.KeyPress += DightKey;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(548, 10);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 10);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Год выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 10);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 10);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Артикул";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(radioButtonTitle);
            tabPage3.Controls.Add(radioButtonAuthor);
            tabPage3.Controls.Add(radioButtonId);
            tabPage3.Controls.Add(textBoxSearch);
            tabPage3.Controls.Add(labelSearch);
            tabPage3.Controls.Add(SearchBook);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(782, 402);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Поиск книги";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitle
            // 
            radioButtonTitle.AutoSize = true;
            radioButtonTitle.Location = new Point(17, 92);
            radioButtonTitle.Margin = new Padding(2, 2, 2, 2);
            radioButtonTitle.Name = "radioButtonTitle";
            radioButtonTitle.Size = new Size(77, 19);
            radioButtonTitle.TabIndex = 6;
            radioButtonTitle.Text = "Название";
            radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuthor
            // 
            radioButtonAuthor.AutoSize = true;
            radioButtonAuthor.Location = new Point(17, 54);
            radioButtonAuthor.Margin = new Padding(2, 2, 2, 2);
            radioButtonAuthor.Name = "radioButtonAuthor";
            radioButtonAuthor.Size = new Size(58, 19);
            radioButtonAuthor.TabIndex = 5;
            radioButtonAuthor.Text = "Автор";
            radioButtonAuthor.UseVisualStyleBackColor = true;
            // 
            // radioButtonId
            // 
            radioButtonId.AutoSize = true;
            radioButtonId.Location = new Point(17, 17);
            radioButtonId.Margin = new Padding(2, 2, 2, 2);
            radioButtonId.Name = "radioButtonId";
            radioButtonId.Size = new Size(71, 19);
            radioButtonId.TabIndex = 4;
            radioButtonId.Text = "Артикул";
            radioButtonId.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(17, 132);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(82, 23);
            textBoxSearch.TabIndex = 3;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(117, 169);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Вывод";
            // 
            // SearchBook
            // 
            SearchBook.Location = new Point(17, 165);
            SearchBook.Name = "SearchBook";
            SearchBook.Size = new Size(75, 23);
            SearchBook.TabIndex = 0;
            SearchBook.Text = "Поиск";
            SearchBook.UseVisualStyleBackColor = true;
            SearchBook.Click += SearchBookClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView1);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(listViewReader);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 3, 3, 3);
            tabPage4.Size = new Size(782, 402);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Картотека";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(22, 27);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(715, 277);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sunameDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, groupDataGridViewTextBoxColumn });
            dataGridView1.DataSource = readerBindingSource2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(776, 396);
            dataGridView1.TabIndex = 1;
            // 
            // sunameDataGridViewTextBoxColumn
            // 
            sunameDataGridViewTextBoxColumn.DataPropertyName = "Suname";
            sunameDataGridViewTextBoxColumn.HeaderText = "Suname";
            sunameDataGridViewTextBoxColumn.MinimumWidth = 6;
            sunameDataGridViewTextBoxColumn.Name = "sunameDataGridViewTextBoxColumn";
            sunameDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            groupDataGridViewTextBoxColumn.HeaderText = "Group";
            groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // readerBindingSource2
            // 
            readerBindingSource2.DataSource = typeof(LogicLib.Reader);
            // 
            // listViewReader
            // 
            listViewReader.Location = new Point(268, 0);
            listViewReader.Margin = new Padding(2, 2, 2, 2);
            listViewReader.Name = "listViewReader";
            listViewReader.Size = new Size(485, 315);
            listViewReader.TabIndex = 2;
            listViewReader.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBoxSurname);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(button3);
            tabPage5.Controls.Add(textBoxGroup);
            tabPage5.Controls.Add(textBoxName);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 3, 3, 3);
            tabPage5.Size = new Size(782, 402);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Добавить читателя";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(120, 32);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(198, 23);
            textBoxSurname.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 14);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 5;
            label9.Text = "Фамилия";
            // 
            // button3
            // 
            button3.Location = new Point(419, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddReaderClick;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(324, 31);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(89, 23);
            textBoxGroup.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 31);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(95, 23);
            textBoxName.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 14);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 1;
            label8.Text = "Номер группы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 14);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 0;
            label7.Text = "Имя ";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(labelGet);
            tabPage6.Controls.Add(button4);
            tabPage6.Controls.Add(textBoxId);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(textBoxGetReaderSurname);
            tabPage6.Controls.Add(label10);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 3, 3, 3);
            tabPage6.Size = new Size(782, 402);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Выдать книгу";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelGet
            // 
            labelGet.AutoSize = true;
            labelGet.Location = new Point(294, 57);
            labelGet.Margin = new Padding(2, 0, 2, 0);
            labelGet.Name = "labelGet";
            labelGet.Size = new Size(38, 15);
            labelGet.TabIndex = 5;
            labelGet.Text = "label6";
            // 
            // button4
            // 
            button4.Location = new Point(274, 28);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Выдать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonGet;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(156, 29);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(156, 11);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 2;
            label11.Text = "Книга";
            // 
            // textBoxGetReaderSurname
            // 
            textBoxGetReaderSurname.Location = new Point(29, 29);
            textBoxGetReaderSurname.Name = "textBoxGetReaderSurname";
            textBoxGetReaderSurname.Size = new Size(100, 23);
            textBoxGetReaderSurname.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 11);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 0;
            label10.Text = "Читатель";
            // 
            // readerBindingSource1
            // 
            readerBindingSource1.DataSource = typeof(LogicLib.Reader);
            // 
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(LogicLib.Reader);
            // 
            // booksBindingSource1
            // 
            booksBindingSource1.DataSource = typeof(LogicLib.Book);
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 419);
            Controls.Add(tabControl1);
            Name = "Menu";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dataGridViewBooks;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox NameBookTextBox;
        private TextBox AuthorTextBox;
        private TextBox IdBookTextBox;
        private Button button1;
        private TextBox QuantityBookTextBox;
        private TextBox AgeBookTextBox;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Button SearchBook;
        private TextBox textBoxSurname;
        private Label label9;
        private Button button3;
        private TextBox textBoxGroup;
        private TextBox textBoxName;
        private Label label8;
        private Label label7;
        private Button button4;
        private TextBox textBoxId;
        private Label label11;
        private TextBox textBoxGetReaderSurname;
        private Label label10;
        private DataGridView dataGridView1;
        private ListView listViewBook;
        private ListView listViewReader;
        private RadioButton radioButtonAuthor;
        private RadioButton radioButtonId;
        private RadioButton radioButtonTitle;
        private Label labelGet;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageBookDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countBookDataGridViewTextBoxColumn;
        private BindingSource booksBindingSource;
        private BindingSource readerBindingSource;
        private BindingSource booksBindingSource1;
        private DataGridViewTextBoxColumn sunameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private BindingSource readerBindingSource1;
        private ListView listView1;
        private BindingSource readerBindingSource2;
    }
}