using System;

namespace Divide
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
            

            if (x<y || x%y!=0)
            {
                Console.Write("First Number Must be Higher Than Second !");
            }
            if (x % 2 == 0 && y % 2 != 0)
            {
                Console.Write("First Number must be Even Number !");
            }

            if (x % 2 != 0 && x % 2 == 0)
            {
                Console.Write("Second Number must be Even Number !");
            }


            else
            {
                z = x / y;
                Console.WriteLine("Result :" + z);
            }

            
            Console.ReadKey();
        }
    }
}
