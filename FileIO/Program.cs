using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            string Path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIONew.txt";

            File.Delete(Path);

            Console.ReadKey();

            

            
            

        }
    }
}
