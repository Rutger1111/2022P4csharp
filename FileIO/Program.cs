using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Path.GetRandomFileName() + ".txt";

            using (StreamWriter SW = File.CreateText(@"C:\Users\info\OneDrive\Bureaublad\c# lessen\c#2\c-2\opdracht1\" + filename))
            {
                SW.WriteLine("goodhell");
                SW.WriteLine("goodhell");
                SW.WriteLine("goodhell");
            }

            string[] lines = File.ReadAllLines(@"C:\Users\info\OneDrive\Bureaublad\c# lessen\c#2\c-2\opdracht1\" + filename);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
