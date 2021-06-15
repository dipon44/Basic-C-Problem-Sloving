using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,temp;
            Console.Write("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Two Numbers Are : " + x + "\t" + y+ "\n");

            temp = x;
            x = y;
            y = temp;

            Console.Write("After Swaping :   "+x+"\t"+y);
            Console.ReadKey();

        }
    }
}
