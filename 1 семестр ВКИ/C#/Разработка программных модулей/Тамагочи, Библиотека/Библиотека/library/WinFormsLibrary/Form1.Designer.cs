namespace WinFormsLibrary
{
    partial class FormLibrary
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listViewBook = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            bookAddButton = new Button();
            textBoxCopies = new TextBox();
            textBoxYear = new TextBox();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxId = new TextBox();
            tabPage3 = new TabPage();
            listViewReader = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            tabPage4 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            buttonAddReader = new Button();
            textBoxName = new TextBox();
            textBoxGroup = new TextBox();
            textBoxSurname = new TextBox();
            tabPage5 = new TabPage();
            labelSearch = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            radioButtonTitle = new RadioButton();
            radioButtonAuthor = new RadioButton();
            radioButtonId = new RadioButton();
            tabPage6 = new TabPage();
            labelGet = new Label();
            label2 = new Label();
            textBoxGetReaderSurname = new TextBox();
            label11 = new Label();
            buttonGet = new Button();
            textBoxIdGet = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
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
            tabControl1.Location = new Point(15, 17);
            tabControl1.Margin = new Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 596);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listViewBook);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(4, 4, 4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 4, 4, 4);
            tabPage1.Size = new Size(990, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Библиотека";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewBook
            // 
            listViewBook.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewBook.Location = new Point(149, 66);
            listViewBook.Margin = new Padding(4, 4, 4, 4);
            listViewBook.Name = "listViewBook";
            listViewBook.Size = new Size(628, 326);
            listViewBook.TabIndex = 0;
            listViewBook.UseCompatibleStateImageBehavior = false;
            listViewBook.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Артикул";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Автор";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Название";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Год издания";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Количество экземпляров";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 180;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(bookAddButton);
            tabPage2.Controls.Add(textBoxCopies);
            tabPage2.Controls.Add(textBoxYear);
            tabPage2.Controls.Add(textBoxTitle);
            tabPage2.Controls.Add(textBoxAuthor);
            tabPage2.Controls.Add(textBoxId);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Margin = new Padding(4, 4, 4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 4, 4, 4);
            tabPage2.Size = new Size(990, 562);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить книгу";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(678, 48);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 21);
            label7.TabIndex = 11;
            label7.Text = "Количетсво копий";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 48);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 21);
            label6.TabIndex = 10;
            label6.Text = "Год издания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 9;
            label5.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 48);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 8;
            label4.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Артикул";
            // 
            // bookAddButton
            // 
            bookAddButton.Location = new Point(54, 199);
            bookAddButton.Margin = new Padding(4, 4, 4, 4);
            bookAddButton.Name = "bookAddButton";
            bookAddButton.Size = new Size(810, 32);
            bookAddButton.TabIndex = 6;
            bookAddButton.Text = "Добавить Книгу";
            bookAddButton.UseVisualStyleBackColor = true;
            bookAddButton.Click += bookAddButton_Click;
            // 
            // textBoxCopies
            // 
            textBoxCopies.Location = new Point(678, 83);
            textBoxCopies.Margin = new Padding(4, 4, 4, 4);
            textBoxCopies.Name = "textBoxCopies";
            textBoxCopies.Size = new Size(127, 29);
            textBoxCopies.TabIndex = 4;
            textBoxCopies.KeyPress += textBoxCopies_KeyPress;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(541, 83);
            textBoxYear.Margin = new Padding(4, 4, 4, 4);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(127, 29);
            textBoxYear.TabIndex = 3;
            textBoxYear.KeyPress += textBoxYear_KeyPress;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(405, 83);
            textBoxTitle.Margin = new Padding(4, 4, 4, 4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(127, 29);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(269, 83);
            textBoxAuthor.Margin = new Padding(4, 4, 4, 4);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(127, 29);
            textBoxAuthor.TabIndex = 1;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(132, 83);
            textBoxId.Margin = new Padding(4, 4, 4, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(127, 29);
            textBoxId.TabIndex = 0;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listViewReader);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Margin = new Padding(4, 4, 4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 4, 4, 4);
            tabPage3.Size = new Size(990, 562);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Картатека";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewReader
            // 
            listViewReader.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listViewReader.Location = new Point(31, 8);
            listViewReader.Margin = new Padding(4, 4, 4, 4);
            listViewReader.Name = "listViewReader";
            listViewReader.Size = new Size(693, 326);
            listViewReader.TabIndex = 1;
            listViewReader.UseCompatibleStateImageBehavior = false;
            listViewReader.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Имя";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Фамилия";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Группа";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Книги";
            columnHeader9.Width = 300;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(buttonAddReader);
            tabPage4.Controls.Add(textBoxName);
            tabPage4.Controls.Add(textBoxGroup);
            tabPage4.Controls.Add(textBoxSurname);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Margin = new Padding(4, 4, 4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 4, 4, 4);
            tabPage4.Size = new Size(990, 562);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Добавить читателя";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(552, 181);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 16;
            label10.Text = "Группа";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(415, 181);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 15;
            label9.Text = "Фамилия";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 181);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 14;
            label8.Text = "Имя";
            // 
            // buttonAddReader
            // 
            buttonAddReader.Location = new Point(89, 326);
            buttonAddReader.Margin = new Padding(4, 4, 4, 4);
            buttonAddReader.Name = "buttonAddReader";
            buttonAddReader.Size = new Size(810, 32);
            buttonAddReader.TabIndex = 13;
            buttonAddReader.Text = "Добавить читателя";
            buttonAddReader.UseVisualStyleBackColor = true;
            buttonAddReader.Click += buttonAddReader_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(279, 206);
            textBoxName.Margin = new Padding(4, 4, 4, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(127, 29);
            textBoxName.TabIndex = 9;
            // 
            // textBoxGroup
            // 
            textBoxGroup.Location = new Point(552, 206);
            textBoxGroup.Margin = new Padding(4, 4, 4, 4);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.Size = new Size(127, 29);
            textBoxGroup.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(415, 206);
            textBoxSurname.Margin = new Padding(4, 4, 4, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(127, 29);
            textBoxSurname.TabIndex = 7;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(labelSearch);
            tabPage5.Controls.Add(buttonSearch);
            tabPage5.Controls.Add(textBoxSearch);
            tabPage5.Controls.Add(radioButtonTitle);
            tabPage5.Controls.Add(radioButtonAuthor);
            tabPage5.Controls.Add(radioButtonId);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Margin = new Padding(4, 4, 4, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(4, 4, 4, 4);
            tabPage5.Size = new Size(990, 562);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Поиск";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(237, 52);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(0, 21);
            labelSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(59, 189);
            buttonSearch.Margin = new Padding(4, 4, 4, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(96, 32);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(49, 122);
            textBoxSearch.Margin = new Padding(4, 4, 4, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(127, 29);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // radioButtonTitle
            // 
            radioButtonTitle.AutoSize = true;
            radioButtonTitle.Location = new Point(64, 87);
            radioButtonTitle.Margin = new Padding(4, 4, 4, 4);
            radioButtonTitle.Name = "radioButtonTitle";
            radioButtonTitle.Size = new Size(99, 25);
            radioButtonTitle.TabIndex = 2;
            radioButtonTitle.Text = "Название";
            radioButtonTitle.UseVisualStyleBackColor = true;
            // 
            // radioButtonAuthor
            // 
            radioButtonAuthor.AutoSize = true;
            radioButtonAuthor.Location = new Point(64, 52);
            radioButtonAuthor.Margin = new Padding(4, 4, 4, 4);
            radioButtonAuthor.Name = "radioButtonAuthor";
            radioButtonAuthor.Size = new Size(74, 25);
            radioButtonAuthor.TabIndex = 1;
            radioButtonAuthor.Text = "Автор";
            radioButtonAuthor.UseVisualStyleBackColor = true;
            // 
            // radioButtonId
            // 
            radioButtonId.AutoSize = true;
            radioButtonId.Checked = true;
            radioButtonId.Location = new Point(64, 17);
            radioButtonId.Margin = new Padding(4, 4, 4, 4);
            radioButtonId.Name = "radioButtonId";
            radioButtonId.Size = new Size(90, 25);
            radioButtonId.TabIndex = 0;
            radioButtonId.TabStop = true;
            radioButtonId.Text = "Артикль";
            radioButtonId.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(labelGet);
            tabPage6.Controls.Add(label2);
            tabPage6.Controls.Add(textBoxGetReaderSurname);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(buttonGet);
            tabPage6.Controls.Add(textBoxIdGet);
            tabPage6.Location = new Point(4, 30);
            tabPage6.Margin = new Padding(4, 4, 4, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(4, 4, 4, 4);
            tabPage6.Size = new Size(990, 562);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Выдача";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // labelGet
            // 
            labelGet.AutoSize = true;
            labelGet.Location = new Point(366, 60);
            labelGet.Margin = new Padding(4, 0, 4, 0);
            labelGet.Name = "labelGet";
            labelGet.Size = new Size(0, 21);
            labelGet.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 11;
            label2.Text = "Фамилия читателя";
            // 
            // textBoxGetReaderSurname
            // 
            textBoxGetReaderSurname.Location = new Point(738, 56);
            textBoxGetReaderSurname.Margin = new Padding(4, 3, 4, 3);
            textBoxGetReaderSurname.Name = "textBoxGetReaderSurname";
            textBoxGetReaderSurname.Size = new Size(140, 29);
            textBoxGetReaderSurname.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(198, 31);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(77, 21);
            label11.TabIndex = 7;
            label11.Text = "Артикуль";
            // 
            // buttonGet
            // 
            buttonGet.Location = new Point(405, 440);
            buttonGet.Margin = new Padding(4, 4, 4, 4);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(139, 32);
            buttonGet.TabIndex = 1;
            buttonGet.Text = "Выдать книгу";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // textBoxIdGet
            // 
            textBoxIdGet.Location = new Point(198, 56);
            textBoxIdGet.Margin = new Padding(4, 4, 4, 4);
            textBoxIdGet.Name = "textBoxIdGet";
            textBoxIdGet.Size = new Size(127, 29);
            textBoxIdGet.TabIndex = 0;
            textBoxIdGet.KeyPress += textBoxIdGet_KeyPress;
            // 
            // FormLibrary
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLibrary";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView listViewBook;
        private TabPage tabPage2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button bookAddButton;
        private TextBox textBoxCopies;
        private TextBox textBoxYear;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxId;
        private TabPage tabPage3;
        private ListView listViewReader;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TabPage tabPage4;
        private Button buttonAddReader;
        private TextBox textBoxName;
        private TextBox textBoxGroup;
        private TextBox textBoxSurname;
        private TabPage tabPage5;
        private RadioButton radioButtonTitle;
        private RadioButton radioButtonAuthor;
        private RadioButton radioButtonId;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private TabPage tabPage6;
        private Button buttonGet;
        private TextBox textBoxIdGet;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label11;
        private ColumnHeader columnHeader9;
        private Label label2;
        private TextBox textBoxGetReaderSurname;
        private Label labelGet;
    }
}