using System;

namespace Custom
{
    class Program
    {
        //Proble 19
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.Write("Enter First Number : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                int y = Convert.ToInt32(Console.ReadLine());

                int p = 3 * (x + y);
                if (x == y)
                {
                    Console.Write(p + "\n");
                }
                else
                {
                    Console.Write(x + y+"\n");
                }
            }
            
        }
    }
}
