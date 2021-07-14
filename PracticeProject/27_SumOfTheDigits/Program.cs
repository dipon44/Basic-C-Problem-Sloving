using System;

namespace _27_SumOfTheDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Give an Number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }

            Console.Write("Sum of the all Digits is : " + sum);
            Console.ReadKey();
        }
    }
}
