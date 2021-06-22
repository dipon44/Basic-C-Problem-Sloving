using System;

namespace SumOfFirst500PrimeNumbers
{
    class Program
    {
        //Problem 26
        static void Main(string[] args)
        {
            Console.Write("Enter Bound Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            long sum = 0;
            int ctr = 0;
            int n = 2;
            
            while(ctr <x)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine("Sum of First {0} Prime Number is :{1}",x, sum.ToString());
        }

        public static bool isPrime(int n)
        {
            int p = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= p; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
