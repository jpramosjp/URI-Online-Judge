using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + string.Format("{0:0.00000}",((a*3.5 + b*7.5)/11)));


        }
    }
}