using System;

namespace GivenIntegerIsWithin20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 22 
            for(; ; )
            {
                Console.WriteLine("Enter First Number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = 20;
                if (Math.Abs(x - 100) <= y || Math.Abs(x - 200) <= y)
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine("False");
            }
            
        }
    }
}
