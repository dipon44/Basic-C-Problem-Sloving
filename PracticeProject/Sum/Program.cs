using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());

            z = x + y;

            Console.Write("Sum is : " + z);

            Console.ReadKey();
        }
    }
}
