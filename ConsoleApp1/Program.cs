using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class Program
    {
        static string Sre(int x, int y)
        {
            return x + y.ToString();
        }
        static void Main(string[] args)
        {
            Func<int, int, string> func = new Func<int, int, string>(Sre);
            string sum = func(20, 20);
            Console.WriteLine(sum);
          
           








            //string fullPath = string.Empty;

            //List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
            //try
            //{
            //    for (int i = 0; i < drives.Count; i++)
            //    {
            //        if(drives[i].IsReady)
            //        Console.WriteLine($"Имя:{drives[i].Name}\nПолный размер:{drives[i].TotalSize}\nСвободное место:{drives[i].TotalFreeSpace}");
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Выберете порядковый номер диска:");
            //int drivePOsition = int.Parse(Console.ReadLine());

            //fullPath += drives[drivePOsition].Name;

            //Console.Clear();

            //DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
            //FileSystemInfo[] systemFile = directoryInfo.GetFileSystemInfos();

            //for (int i = 0; i < systemFile.Length; i++)
            //{
            //    //string extension = string.IsNullOrEmpty(systemFile[i].Extension) ? "---" : systemFile[i].Extension;
            //    string extension = "---";
            //    if (!string.IsNullOrEmpty(systemFile[i].Extension))
            //    {
            //        extension = systemFile[i].Extension;
            //    }
            //    Console.WriteLine($"{i}. Имя:{systemFile[i].Name} Расширение:{extension}");
            //}
            //Console.WriteLine("Выберите порядковый номер файла или папки:");
            //int systemInfoPosition = int.Parse(Console.ReadLine());
            //fullPath += systemFile[systemInfoPosition].Name;
            //if (!string.IsNullOrEmpty(systemFile[systemInfoPosition].Extension))
            //{
            //    Process.Start(fullPath);
            //}

            //File.Create(@"C:\1\data.txt").Close();
            //using (StreamWriter writer = new StreamWriter(@"C:\1\data.txt"))
            //{
            //    string data = "Какой-то текст";
            //    writer.WriteLine(data);
            //}

            //using (StreamReader reader = new StreamReader(@"C:\1\data.txt"))
            //{
            //    string result = reader.ReadToEnd();
            //    Console.WriteLine(result);
            //}
            //using (var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
            //{
            //    string data = "123asd";

            //    byte[] array = Encoding.UTF8.GetBytes(data);
            //    stream.Write(array, 0, array.Length);
            //}

            //using (var stream = new FileStream(@"C:\1\data.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] array = new byte[stream.Length];
            //    stream.Read(array, 0, array.Length);
            //    string result = Encoding.UTF8.GetString(array);
            //}


           
        }
    }
}
