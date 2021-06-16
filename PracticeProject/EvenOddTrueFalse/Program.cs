using System;

namespace EvenOddTrueFalse
{
    class Program
    {
        //Problem No 18
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int y = Convert.ToInt32(Console.ReadLine());
            if(x>0 && y<0 || x<0 && y>0) 
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False!");
            }
        }
    }
}
