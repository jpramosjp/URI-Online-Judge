using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0:0.000}", (x*y)/12));
        }
    }
}