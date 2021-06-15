using System;

namespace ScreenOutputofDiffOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int add, sub, mul, div, mod;

            Console.Write("Enter First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());

            add = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
            mod = x % y;

            Console.Write("{0}+{1}={2}",x,y,add+"\n");
            Console.Write("{0}-{1}={2}",x,y,sub +"\n");
            Console.Write("{0}*{1}={2}",x,y,mul + "\n");
            Console.Write("{0}/{1}={2}",x,y, div + "\n");
            Console.Write("{0} mod {1} = {2}",x,y, mod + "\n");

            Console.ReadKey();


        }
    }
}
