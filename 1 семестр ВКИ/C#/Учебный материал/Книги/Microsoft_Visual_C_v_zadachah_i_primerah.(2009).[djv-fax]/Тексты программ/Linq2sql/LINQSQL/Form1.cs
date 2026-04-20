/* 
   Этот пример демонстрирует использование технологии LINQ для доступа к базе данных Microsoft SQL Server.
   Добавить в проект класс LINQ to SQL clasees (команда Project Add New Item)
   В окне Solution explorer сделать двойной щелчок на элементе DataClassess1.dbml.
   В окне Properties задать значение свойства Connection.Connection_String объекта DataClasses1DataContext – указать имя файла базы данных (например, D:\Database\nkdemo.mdf).
*/  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace LINQSQL
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // объявление строки таблицы БД
        // таблица Contacts состоит из
        // трех столбцов: FName, LName и Phone
        [Table]
        public class Contacts
        {
            [Column]
            public string FName;
            [Column]
            public string LName;
            [Column]
            public string Phone;

        };

        private void button1_Click(object sender, EventArgs e)
        {
            // объект DataContex обеспечивает доступ к БД
            // класс DataClasses1DataContext генерирует среда разработки
            // в результате добовления к проекту элемента LINQ to SQL Classes.
            // Свойство Connection.ConnectionString объекта dataContex определяет
            // базу данных, к которой надо подключиться. Значение этого свойства
            // устанавливается в окне Properties и сохраняется в файле параметров
         
            // создать объект dataContex
            var dataContex = new DataClasses1DataContext();

            // таблица сontacts 
            Table<Contacts> contacts;

            // заролнить таблицу данными из из БД
            contacts = dataContex.GetTable<Contacts>();

           int nRec = contacts.Count();
           label1.Text = "ConnectionString: " + dataContex.Connection.ConnectionString;

            Contacts aRow; // строка таблицы 

// извлечение информации из БД
/*            try
            {
                aRow = contacts.Single(c => c.FName.Contains("дани"));
                label1.Text = aRow.FName + aRow.LName + aRow.Phone;
            }
            catch
            {
                label1.Text = "В БД нет запрашиваемой информации";
            }

*/            
            
            // вывести таблицу
            foreach  ( Contacts a in contacts)
            {
              
                    listBox1.Items.Add(a.FName + a.LName + a.Phone);
                
            }
        }
    }
}
