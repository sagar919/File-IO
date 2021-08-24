using System;
using System.IO;


namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIO.txt";

            string copyPath = @"C:\Users\slad\OneDrive - MORNINGSTAR INC\Desktop\Test\FileIONew.txt";

            File.Copy(path, copyPath);

            
            

        }
    }
}
