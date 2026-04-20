using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using System.Data.SqlServerCe;
/*  
    Чтобы пространство имен System.Data.SqlServerCe
    стало доступно, надо добавить ссылку на файл сборки
    System.Data.SqlServerCe.dll, в котором оно определено.
    Для этого надо в меню Project выбрать команду
    Add Reference и указать файл.
*/

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // настройка компонента ListView:
            // увеличим ширину компонента на 17 - ширину
            // полосы прокрутки
            int w = 0;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                w += listView1.Columns[i].Width;
            }
            
            if (listView1.BorderStyle == BorderStyle.Fixed3D)
                w += 4;
            
            listView1.Width = w+17;  // 17 - область отображения полосы прокрутки 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Cоздать БД SQL Server Compact Edition.
            // Если путь к файлу не указан, БД будет создана
            // в каталоге приложения
            SqlCeEngine engine;
            
            engine = new SqlCeEngine("Data Source='contacts.sdf';");
            if (!(File.Exists("contacts.sdf")))
            {
                engine.CreateDatabase();
                SqlCeConnection connection = new SqlCeConnection(engine.LocalConnectionString);
                connection.Open();
                SqlCeCommand command = connection.CreateCommand();
                command.CommandText =
                    "CREATE TABLE contacts (cid int IDENTITY(1,1), name nvarchar(50) NOT NULL, phone nvarchar(50), email nvarchar(50))";
                command.ExecuteScalar();
                connection.Close();
            }
            else
            {
                ShowDB();
            }
        }

        private void ShowDB()
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source='contacts.sdf';");
            SqlCeConnection connection = new SqlCeConnection(engine.LocalConnectionString);
            connection.Open();
            SqlCeCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM contacts ORDER BY name";
            SqlCeDataReader dataReader = command.ExecuteReader();

            string st;  // значение поля БД
            int itemIndex = 0;

            listView1.Items.Clear();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    st = dataReader.GetValue(i).ToString();
                    switch (i)
                    {
                        case 0:  // поле cid
                            break;
                        case 1:  // поле name
                            listView1.Items.Add(st);
                            break;
                        case 2:  // поле phone
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                        case 3:  // поле email
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                    };
                }
                itemIndex++;
            }
            connection.Close();
        }

        // изменился текст в поле редактирования
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // кнопка Добавить становится доступной, если информация введена
            // в поле Имя и в какое-либо из полей Телефон или E-mail
            if ((textBox1.TextLength > 0) && 
                  ((textBox2.TextLength > 0) || (textBox3.TextLength > 0)))
                button1.Enabled = true;
            else
                {
                    button1.Enabled = false; 
                }
        }

        // щелчок на кнопке Добавить
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection("Data Source ='contacts.sdf'");
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO contacts(name, phone,email) VALUES(?,?,?)";
            command.Parameters.Add("name", textBox1.Text);
            command.Parameters.Add("phone", textBox2.Text);
            command.Parameters.Add("email", textBox3.Text);
            command.ExecuteScalar();
            conn.Close();

            // очистить поля ввода
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            ShowDB();

            // установить курсор в поле textBox1
            textBox1.Focus();
        }

        // щелчок на кнопке Найти
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source='contacts.sdf';");
            SqlCeConnection connection = new SqlCeConnection(engine.LocalConnectionString);
            connection.Open();
            
            SqlCeCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM contacts WHERE (name LIKE ?)";
            command.Parameters.Add("name", "%" + textBox1.Text + "%");
            
            SqlCeDataReader dataReader = command.ExecuteReader();

            string st;  // значение поля БД
            int itemIndex = 0;

            listView1.Items.Clear();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    st = dataReader.GetValue(i).ToString();
                    switch (i)
                    {
                        case 0:  // поле cid
                            break;
                        case 1:  // поле name
                            listView1.Items.Add(st);
                            break;
                        case 2:  // поле phone
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                        case 3:  // поле email
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                    };
                }
                itemIndex++;

            }
            connection.Close();
            
        }

        // щелчок на кнопке Удалить
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source='contacts.sdf';");
            SqlCeConnection connection = new SqlCeConnection(engine.LocalConnectionString);
            connection.Open();

            SqlCeCommand command = connection.CreateCommand();

            command.CommandText = "DELETE FROM contacts WHERE ((name = ?) AND (phone = ?) AND (email = ?))";
            command.Parameters.Add("name", textBox1.Text);
            command.Parameters.Add("phpne", textBox2.Text);
            command.Parameters.Add("email", textBox3.Text);

            command.ExecuteScalar();

            ShowDB();

            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCeEngine engine = new SqlCeEngine("Data Source='contacts.sdf';");
            SqlCeConnection connection = new SqlCeConnection(engine.LocalConnectionString);
            connection.Open();
            SqlCeCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM contacts ORDER BY name";
            SqlCeDataReader dataReader = command.ExecuteReader();


            


            string st;  // значение поля БД
            int itemIndex = 0;

            listView1.Items.Clear();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    st = dataReader.GetValue(i).ToString();
                    switch (i)
                    {
                        case 0:  // поле cid
                            break;
                        case 1:  // поле name
                            listView1.Items.Add(st);
                            break;
                        case 2:  // поле phone
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                        case 3:  // поле email
                            listView1.Items[itemIndex].SubItems.Add(st);
                            break;
                    };
                }
                itemIndex++;
            }
            connection.Close();
        }

    }
}
