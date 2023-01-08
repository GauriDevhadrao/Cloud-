using System;
using System.IO;

namespace Assignment_7_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\GDEVHADR\project_dir";

            var dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("******Directories*******");
            Console.Write("\n");
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.FullName}");
            }
            Console.WriteLine("\n*******All .txt files*******");
            Console.Write("\n");
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} - { fileInfo.Length } bytes");
            }
        }
    }
}