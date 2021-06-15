using System;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a Number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look like {0} :) ",x);
            Console.ReadLine();
        }
    }
}
