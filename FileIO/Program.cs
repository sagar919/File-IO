using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIO.txt";

            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

        }
    }
}
