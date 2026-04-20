using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// эти ссылки вставлены вручную
using System.Xml.Linq;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        XDocument doc;
        DirectoryInfo di;
        
        public Form1()
        {
            InitializeComponent();
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

            // настройка компонента listView
            listView1.View = View.Details;
            listView1.GridLines = true;
            //listView1.Sorting = SortOrder.Ascending;

            listView1.Columns.Add("Автор");
            listView1.Columns[0].Width = 90;
            listView1.Columns.Add("Название");
            listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width - 4;
        }

        // загрузить XML-документ из файлв
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                doc = XDocument.Load(di.FullName + "\\books.xml");
                button1.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            catch (Exception aException)
            {
                MessageBox.Show(aException.Message, "Load XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IEnumerable<XElement> books = doc.Elements();
            foreach (XElement aBooks in books.Elements())
            {
                listView1.Items.Add(aBooks.Element("Author").Value);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(aBooks.Element("Title").Value);
            }
            button2.Enabled = false;
        }

        // добавить элемент в XML-документ
        private void button1_Click(object sender, EventArgs e)
        {
            doc.Element("books").Add(new XElement("book",
                            new XElement("Author", textBox2.Text),
                            new XElement("Title", textBox1.Text),
                            new XElement("Description", textBox4.Text)
                        )
                   );
        }
      
        // создать XML-файл
        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(di.FullName+"\\books.xml");
            if (fi.Exists)
            {
                DialogResult dr;
                dr = MessageBox.Show("Файл " + fi.FullName + 
                       " существует.\nЗаменить его новым?",
                       "Create XML",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            
            doc =
                new XDocument(
                    new XElement("books",
                        new XElement("book",
                            new XElement("Author", "Культин Н.Б."),
                            new XElement("Title", "Visual C# в примерах"),
                            new XElement("Description", "")
                        ),
                        new XElement("book",
                            new XElement("Author", "Н. Культин"),
                            new XElement("Title", "Самоучитьель Visual C#"),
                            new XElement("Description", "")
                        ),
                        new XElement("book",
                            new XElement("Author", "Культин"),
                            new XElement("Title", "Основы программирования в Turbo Pascal 7.0 и Delphi"),
                            new XElement("Description", "")
                        )
                     )
                   );

            doc.Save(di.FullName+"\\books.xml");
        }

        // сохранить изменения
        private void button4_Click(object sender, EventArgs e)
        {
            doc.Save(di.FullName + "\\books.xml");
        }

        // щелчок на кнопке Найти
        private void button5_Click(object sender, EventArgs e)
        {
            // выбрать элементы у которых поле Author
            // содержит текст, введенный пользователем
            IEnumerable<XElement> query =
                from b in doc.Elements().Elements()
                where b.Elements("Author").Any(n => n.Value.Contains(textBox3.Text))
                select b;
           
            listView1.Items.Clear();
            
            // вывести список элементов
            //bool firstElement = true; 
           
            foreach (XElement e1 in query)
            {
                //st = st + "\n" + xe.ToString();
                bool firstElement = true;
                foreach (XElement e2 in e1.Elements())
                {
                    if ( firstElement == true)
                    {
                        listView1.Items.Add(e2.Value);
                        firstElement = false;
                    }
                    else
                    {
                        listView1.Items[listView1.Items.Count-1].SubItems.Add(e2.Value);
                    }
                 }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("Культин Н.Б.", 0);
            item1.SubItems.Add("Программирование");
            
            ListViewItem item2 = new ListViewItem("Культин", 1);
            item2.SubItems.Add("Visual C# в примерах");
            
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
         }
    }
}
