using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            //problem no 8


            int x,temp;
            Console.Write("Enter a Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Multiplication Table of {0} ", x);

            for(int i=0;i<=10;i++)
            {
                temp = i * x;
                Console.Write("{0} * {1} = {2}", i, x, temp+"\n");
            }
            Console.ReadKey();
            
        }
    }
}
