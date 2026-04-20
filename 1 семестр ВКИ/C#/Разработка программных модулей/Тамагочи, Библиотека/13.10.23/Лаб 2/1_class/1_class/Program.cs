using System;
using System.IO;
using System.Text;

class Program
{
	public class MyClass
	{
     
	}

	class MyFile
	{
		public byte[] data;
		public string path;
		public int size;


        public void ReadFile() 
		{
			using(FileStream fs = File.Open(path, FileMode.Open)) // path - путь до файла
            {
				byte[] buffer = new byte[4096];
				UTF8Encoding temp = new UTF8Encoding(true);

				while (fs.Read(buffer, 0, buffer.Length) > 0)
				{ 
					Console.WriteLine(temp.GetString(buffer));
				}
			}

		}

		public void WriteFile(string writeData)
		{
			using (FileStream fs = File.Open(path, FileMode.Open , FileAccess.Read))
			{
				Byte[] info = new UTF8Encoding(true).GetBytes(writeData);
				fs.Write(info, 0, info.Length);
			}
		}

	}


	static void Main(string[] args)
	{
		MyFile f = new MyFile();
       // f.path = " E:\\C#\\Лаб 2\\1_class\\file.txt"; 
        f.path = "file.txt";
		f.WriteFile("Text");


		f.ReadFile();
		Console.WriteLine(f.data);

   


    }
 
}


