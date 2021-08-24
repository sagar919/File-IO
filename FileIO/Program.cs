using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            string Path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIO.txt";

            using (StreamReader sr = File.OpenText(Path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }


    }
}

