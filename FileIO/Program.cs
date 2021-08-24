using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\git Token.txt";

            if (File.Exists(path))
                Console.WriteLine("File Exists");
            Console.ReadKey();

        }
    }
}
