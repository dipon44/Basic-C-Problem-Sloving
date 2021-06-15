using System;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, mul;

            Console.Write("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            z = Convert.ToInt32(Console.ReadLine());

            mul = x * y * z;

            Console.Write("\t{0}*{1}*{2}={3}", x, y, x, mul);
            Console.ReadKey();

        }
    }
}
