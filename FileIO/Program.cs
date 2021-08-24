using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            string Path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIO.txt";

            using (StreamWriter sw = File.AppendText(Path))
            {
                sw.WriteLine("Hello everyone");
                sw.Close();
            }
        }


    }
}

