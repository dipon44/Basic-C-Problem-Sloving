using System;

namespace ODDNumber
{
    class Program
    {
        //Problem 25
        

        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.Write("Enter Range :\n");
                Console.WriteLine("Enter Start Range Value:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter End Range Value:");
                int y = Convert.ToInt32(Console.ReadLine());

                if (x > y)
                {
                    Console.Write("Error! Please Put Valid Range value!");
                }
                else
                {
                    Console.Write("All ODD Numbers between {0} & {1} are :\n", x, y);
                    for (int p = x; p <= y; p++)
                    {
                        if (p % 2 != 0)
                        {
                            Console.Write(p + "\n");
                        }
                    }
                }
                Console.ReadKey();
            }
            

            
           
        }
    }
}
