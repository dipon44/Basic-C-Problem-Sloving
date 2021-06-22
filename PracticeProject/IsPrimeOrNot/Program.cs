using System;

namespace IsPrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write(IsPrime(input)+"\n");
        }

        public static bool IsPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0)
                {
                    return false;
                } 
            }

            return true;
        }
    }
}
