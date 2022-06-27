using System;
using System.IO;

namespace FileDir
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\info\OneDrive\Bureaublad\c# lessen\c#2\c-2\opdracht1");

            FileInfo[] files = dirinfo.GetFiles();

            foreach (FileInfo fileinfo in files)
            {
                Console.WriteLine(fileinfo.Name.ToString());
            }

            DirectoryInfo[] directories = dirinfo.GetDirectories();

            foreach (DirectoryInfo directoryInfo in directories)
            {
                Console.WriteLine(dirinfo.Name.ToString());
            }
        }
    }
}
