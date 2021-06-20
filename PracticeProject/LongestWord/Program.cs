using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem No 23
            Console.Write("Enter Your Line : ");
            string line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word1 = "";
            int ctr = 0;

            foreach (string Word in words)
            {
                Console.Write(Word+"\n");

                if(Word.Length>ctr)
                {
                    word1 = Word;
                    ctr = Word.Length;

                }

                

            }
            Console.Write("Largest Word Is : " + word1 + "\n");


            Console.ReadKey();
        }
    }
}
