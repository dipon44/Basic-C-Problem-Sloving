using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, a;
            x = -1 + 4 * 6;
            y = (35 + 5) % 7;
            z = 14 + -4 * 6 / 11;
            a = 2 + 15 / 6 * 1 - 7 % 2;

            Console.Write(x + "\n" + y + "\n" + z + "\n" + a);
            Console.ReadKey();
        }
    }
}
