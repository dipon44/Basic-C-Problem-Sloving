using System;

namespace StringintoLowercase
{
    class Program
    {
        //Problem 23
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.Write("Enter Your String : ");
                string x = Console.ReadLine();

                string y = x.ToLower();

                Console.Write("Converted String is : " + y+"\n");
            }
            

        }
    }
}
