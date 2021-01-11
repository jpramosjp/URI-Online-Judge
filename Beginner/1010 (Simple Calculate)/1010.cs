using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            int a = int.Parse(texto[0]), b = int.Parse(texto[1]);
            double e = double.Parse(texto[2]);
            string[] texto2 = Console.ReadLine().Split(' ');
            int c = int.Parse(texto2[0]), d = int.Parse(texto2[1]);
            double f = double.Parse(texto2[2]);
            double result = e * b + d * f;
            Console.WriteLine("VALOR A PAGAR: R$ " + string.Format("{0:0.00}", result));



        }
    }
}