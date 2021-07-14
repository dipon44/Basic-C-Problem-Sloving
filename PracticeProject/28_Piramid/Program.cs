using System;
using System.Collections.Generic;

namespace _28_Piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give An String : ");
            string x = Console.ReadLine();
            Console.WriteLine("\nOriginal String: " + x);
            string result = "";

            List<string> wordsList = new List<string>();

            string[] words = x.Split(new[] {
               " "
              }, StringSplitOptions.None);

            for(int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);

            foreach(string s in wordsList)
            {
                Console.Write("\nReverse String: " +s);
            }


        }
    }
}
