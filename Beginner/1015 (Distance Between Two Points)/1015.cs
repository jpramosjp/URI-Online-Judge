using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            double x1 = double.Parse(texto[0]), y1 = double.Parse(texto[1]);
            string[] texto2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(texto2[0]), y2 = double.Parse(texto2[1]);

            Console.WriteLine( string.Format("{0:0.0000}", Math.Sqrt(Math.Pow(x1 -x2,2) + Math.Pow(y1 - y2,2))));


        }
    }
}