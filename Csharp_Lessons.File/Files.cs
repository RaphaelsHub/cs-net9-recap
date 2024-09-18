using System;
using System.IO;
using System.Text;

namespace Csharp_Lessons.File
{
    public class Files
    {
        private string _path = @"D:\\BookManagement\BookManagement\\Files\\";

        // File-working

        // 1 вариант
        public void CreateFile1(string fileName)
        {
            Stream? file = null;
            try
            {
                file = new FileStream(_path + fileName, FileMode.Create, FileAccess.Write);
                if (file.CanWrite)
                {
                    byte[] strByte = Convert.FromBase64String(fileName);
                    file.Write(strByte, 0, strByte.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                file?.Close();
            }
        }

        // 2 вариант
        public void CreateFile2(string fileName)
        {
            string[] linesToWrite = { "STY", "STR", "STA" };
            using (FileStream file = new FileStream(_path + fileName, FileMode.Create, FileAccess.Write))
            {
                if (file.CanWrite)
                {
                    foreach (var line in linesToWrite)
                    {
                        var strByte = Encoding.UTF8.GetBytes(line + Environment.NewLine);
                        file.Write(strByte, 0, strByte.Length);
                    }
                }
            }
        }

        // 3 вариант
        public void CreateFile3(string fileName)
        {
            using (FileStream fs = new FileStream(_path + fileName, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                var read = fs.Read(bytes, 0, bytes.Length);

                string fileContent = Encoding.UTF8.GetString(bytes);
                string[] linesRead =
                    fileContent.Split(new[] { Environment.NewLine },
                        StringSplitOptions.RemoveEmptyEntries); // Разбиваем строку на массив строк

                foreach (string line in linesRead)
                {
                    Console.WriteLine(line);
                }
            }
        }

        // 4 вариант
        public static void WorkingWithFiles()
        {
            string filePath = "Text.txt";
            string? fileDir = Path.GetDirectoryName(filePath);
            if (fileDir != null && !Directory.Exists(fileDir))
            {
                Directory.CreateDirectory(fileDir);
            }

            string[] Lines = { "SSR", "GB", "USA" };

            File.WriteAllLines(filePath, Lines);
            File.AppendAllLines(filePath, Lines);
            string[] allLines = File.ReadAllLines(filePath);
            string allText = File.ReadAllText(filePath);

            // 5 вариант
            using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                if (Directory.Exists(filePath))
                {
                    var files = Directory.GetFiles(filePath);
                    foreach (var file in files)
                        Console.WriteLine(Path.GetFileName(file));
                }

                fileStream.SetLength(0);
            }

            FileInfo f = new FileInfo(@"Text.txt");
            Console.WriteLine(f.IsReadOnly);
            Console.WriteLine(f.Attributes);
            Console.WriteLine(f.LastWriteTimeUtc);
            Console.WriteLine(f.LastAccessTime);
            Console.WriteLine(f.LastWriteTime);
            Console.WriteLine(f.Extension);
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Name);

            DirectoryInfo b = new DirectoryInfo(Path.GetDirectoryName(filePath));
        }
    }
}
