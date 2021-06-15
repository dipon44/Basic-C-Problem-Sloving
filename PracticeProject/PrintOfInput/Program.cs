using System;

namespace PrintOfInput
{
    class Program
    {

        //Problem 10
        static void Main(string[] args)
        {
            int x, y, z, output1,output2;
            Console.Write("Enter X Value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y Value: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Z Value: ");
            z = Convert.ToInt32(Console.ReadLine());

            output1 = (x + y) * z;
            output2 = (x * y) + (y * z);

            Console.Write("(x+y).z = "+output1+"\n");
            Console.Write("x.y + y.z  = " + output2+"\n");

            Console.ReadLine();
        }
    }
}
