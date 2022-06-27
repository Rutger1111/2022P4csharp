using System;
using System.IO;

namespace FIlesplits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"C:\Users\info\OneDrive\Bureaublad\c# lessen\c#2\c-2\FIlesplits\stringsplit.txt");

            string[] opslag1 = line.Split(":");

            string[] opslag2 = opslag1[1].Split(",");

            Console.WriteLine(opslag1[0]);

            Console.WriteLine(opslag2[0]);

            Console.WriteLine(opslag2[1]);
        }
    }
}
