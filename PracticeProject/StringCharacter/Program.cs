using System;

namespace StringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem No : 17
            Console.Write("Enter String : ");
            string x = Console.ReadLine();
            int y = x.Length;
            Console.WriteLine("String Length : "+y);
            char[] charArr = x.ToCharArray();

            //foreach (char ch in charArr)
            //{
            //    Console.WriteLine(ch);
            //}

            Console.Write("Output is : "+ charArr[0] + x + "" + charArr[0]);

            Console.ReadKey();

            
        }
    }
}
