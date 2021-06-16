using System;

namespace FirstAndLastCharactersChange
{
    class Program
    {
        //problem 16 
        static void Main(string[] args)
        {
            Console.Write("Enter First String : ");
            string x1 = Console.ReadLine();
            Console.Write("Enter Second String : ");
            string y = Console.ReadLine();
            Console.Write("Enter Third String : ");
            string z = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write("Format 1 : " + first_last(x1)+"\n");
            Console.Write("Format 2 : " + first_last(y)+"\n");
            Console.Write("Format 1 : " + first_last(z));

            Console.ReadKey();
        }

        public static string first_last(string p)
        {
            return p.Length > 1
                ? p.Substring(p.Length - 1) + p.Substring(1, p.Length - 2) + p.Substring(0, 1) : p;
        }
    }
}
