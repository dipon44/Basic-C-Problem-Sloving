using System;

namespace Rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            //No 13 problem
            int x;
            Console.Write("Enter A Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            string y = x.ToString();

            Console.WriteLine("Rectengular Format is: ");
            Console.Write(y + y + y+"\n"+y+" "+y+"\n"+ y+" "+y+"\n"+y+" "+y+"\n"+ y + y + y+"\n");
            
            Console.ReadKey();
        }
    }
}
