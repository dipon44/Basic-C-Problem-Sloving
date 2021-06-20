using System;

namespace CheckTheSum
{
    class Program
    {
        //Problem 21 
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int y = Convert.ToInt32(Console.ReadLine());


            int z = x + y;


            if(z==20||x==20||y==20)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }

        }
    }
}
