using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, a;
            double avg;
            Console.Write("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second NUmber : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fourth NUmber : ");
            a = Convert.ToInt32(Console.ReadLine());

            avg = (x + y + z + a) / 4;
            Console.Write("Avg of {0},{1},{2},{3} is {4}", x, y, z, a, avg);
            Console.ReadKey();

        }
    }
}
