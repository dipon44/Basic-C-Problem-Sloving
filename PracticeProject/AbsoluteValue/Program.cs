using System;

namespace AbsoluteValue
{
    class Program
    {
        //Problem No 20 
        
        static void Main(string[] args)
        {

            for(; ; )
            {
                Console.Write("Enter First No : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second No : ");
                int y = Convert.ToInt32(Console.ReadLine());

                int p = x - y;
                if (x > y)
                {
                    Console.Write(p * 2 + "\n");
                }

                else
                {
                    Console.Write(Math.Abs(y - x)+"\n");
                }
            }
            
        }
    }
}
