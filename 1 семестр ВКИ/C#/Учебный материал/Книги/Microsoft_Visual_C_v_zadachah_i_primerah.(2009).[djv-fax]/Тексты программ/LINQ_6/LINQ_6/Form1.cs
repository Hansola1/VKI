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
            
            // настройка компонента listView
            listView1.View = View.Details;
            listView1.GridLines = true;
            //listView1.Sorting = SortOrder.Ascending;

            listView1.Columns.Add("Автор");
            listView1.Columns[0].Width = 90;
            listView1.Columns.Add("Название");
            listView1.Columns[1].Width =
                     listView1.Width - listView1.Columns[0].Width - 4 -17;
            // 4 - ширина границы; 17 - ширина полосы прокрутки
            

            // предполагается, что XML-файл находится
            // в каталоге ApplicationData
            di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            
            // загрузить данные из XML-файла
            try
            {
                doc = XDocument.Load(di.FullName + "\\books.xml");
                          }
            catch (Exception aException)
            {
                MessageBox.Show(aException.Message,
                                "Load XML",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // отобразить данные
            IEnumerable<XElement> query =
                from b in doc.Elements().Elements()
                select b;

            listView1.Items.Clear();

            // ** вывести список элементов (узлов) XML-документа **

            // Чтобы добавить в компонент ListView строку,
            // точнее ячейку в первый столбец,
            // надо добавить элемент в коллекцию Items.
            // Чтобы данные появились во второй строке,
            // надо добавить подэлемент (SubItem) в коллекцию
            // SubItems, соответствующую той строке,
            // в которую надо добавить ячейку.
            foreach (XElement e1 in query)
            {
                bool newElement = true;
                foreach (XElement e2 in e1.Elements())
                {
                    if (newElement == true)
                    {
                        // первый узел - элемент
                        listView1.Items.Add(e2.Value);
                        newElement = false;
                    }
                    else
                    {
                        // остальные узлы - подэлементы 
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(e2.Value);
                    }      
                }
            }
        }
       
    }
}
