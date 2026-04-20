using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using My_lib;
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<Reader> readers = new List<My_lib.Reader>();
        private void InitializeBooks()
        {
            books.Add(new Book(1468, "Л.Н. Толстой", "Война и мир", 1867, 1));
            books.Add(new Book(1469, "Л.Н. Толстой", "Анна Каренина", 1877, 1));
            books.Add(new Book(1470, "Л.Н. Толстой", "Анна Каренина", 2023, 10));
        }

        public Form1()
        {
            InitializeComponent();
            InitializeBooks();
            listView1.Items.Add() = books;//

        }
    }
}
