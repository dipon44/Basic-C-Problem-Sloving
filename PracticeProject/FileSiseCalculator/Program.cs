using System;
using System.IO;

namespace FileSizeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the FilPath : ");
            string path = Console.ReadLine();
            FileInfo f = new FileInfo(path);
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
    }
}
