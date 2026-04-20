/*
 Программа работы с базой данных Microsoft Acces "Контакты" (contacts.mdb)
 Предполагается, что файлы иллюстраций находятся в папке Images,
 которая находится в той же папке, что и файл БД.
 Путь к файлу БД загружается из файла параметров.
 
 © Nikita Kultin, 2008-2009
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO; // для доступа к DirectoryInfo

using WindowsFormsApplication1.Properties; // для доступа к объекту Settings

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dbPath;   // папка приложение
        string imFolder; // папка иллюстраций
        
        // начало работы программы
        private void Form1_Load(object sender, EventArgs e)
        {
            // загрузить путь к файлу БД  из файла конфигурации
            dbPath = Settings.Default.DbPath;
            
            // открыть соединение с БД
            oleDbConnection1.ConnectionString =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                dbPath + "\\Contacts.mdb";

            // папка иллюстраций
            imFolder =  dbPath + "\\Images\\";

            // получить информацию из БД
            oleDbDataAdapter1.Fill(dataSet1.Tables[0]);
        }

        // пользователь нажал клавишу <Delete>
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult r;
            
            r= MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (r == DialogResult.Cancel)
            {
                // отменить операцию удаления записи
                e.Cancel = true;
            }
        }

        // изменилось содержимое поля textBox4 - 
        // отобразить иллюстрацию, имя файла которой
        // находится в этом поле
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string imageFile;
            string msg; // текст, отображаемый в поле компонента pictureBox

            if (textBox4.Text.Length == 0)
            {
                imageFile = imFolder + "nobody.jpg";
            }
            else
                imageFile = imFolder + textBox4.Text;

            try
            {
                msg = "";
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(imageFile);
            }
            catch (System.IO.FileNotFoundException)
            {
                // вывести сообщение об ошибке в поле
                // компонента pictureBox1
                msg = "File nof found: " + imageFile;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
            }
      }

        // щелчок в поле отображения иллюстрации
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите иллюстрацию";
            openFileDialog1.InitialDirectory = imFolder;
            openFileDialog1.Filter = "фото|*.jpg|все файлы|*.*";
            openFileDialog1.FileName = "";
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // пользователь указал файл иллюстрации
                
                // проверим, находится ли выбранный файл
                // в каталоге imFolder
                bool r = openFileDialog1.FileName.ToLower().Contains(
                                openFileDialog1.InitialDirectory.ToLower());
                if (r == true)
                {
                    // копировать не надо т.к. пользователь
                    // указал иллюстрацию, которая
                    // находится в imFolder
                    textBox4.Text = openFileDialog1.SafeFileName;
                }

                else
                {
                    // скопировать файл иллюстрации в папку Images

                    // если в каталоге-приемнике есть файл с таким же
                    // именем, что и копируемый, возникает исключение
                    try
                    {
                        // копировать файл
                        System.IO.File.Copy(openFileDialog1.FileName,
                                            imFolder + openFileDialog1.SafeFileName);

                        textBox4.Text = openFileDialog1.SafeFileName;
                    }
                    catch (Exception ex)
                    {
                        DialogResult dr;
                        dr = MessageBox.Show(ex.Message + " Заменить его?", "",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);
                        if (dr == DialogResult.OK)
                        {
                            // перезаписать файл - значение параметра overwrite = true
                            System.IO.File.Copy(openFileDialog1.FileName,
                                            imFolder + openFileDialog1.SafeFileName, true);
                            textBox4.Text = openFileDialog1.SafeFileName;
                        }
                    }
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle aRect = new Rectangle(1, 1, pictureBox1.Width, pictureBox1.Height);
        }

        // завершение работы программы  
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                oleDbDataAdapter1.Update(dataTable1);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
