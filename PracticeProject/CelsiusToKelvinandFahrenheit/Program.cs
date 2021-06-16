using System;

namespace CelsiusToKelvinandFahrenheit
{
    class Program
    {

        //ProblemNo 14
        static void Main(string[] args)
        {
            double x;
            double kelvin;
            double farhenheight;
            Console.Write("Enter Celcious Amount : ");
            x = Convert.ToDouble(Console.ReadLine());

            kelvin = x + 273;
            farhenheight = x * 18 / 10 + 32;

            Console.Write("Kelvin Amount : "+kelvin+"\n");
            Console.Write("Farhenheight Amount : "+ farhenheight +"\n");
            Console.ReadKey();


        }
    }
}
