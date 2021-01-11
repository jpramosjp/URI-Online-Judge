using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            double a = double.Parse(texto[0]), b = double.Parse(texto[1]), c = double.Parse(texto[2]);
            double result = (a * c) / 2;
            Console.WriteLine("TRIANGULO: ", string.Format("{0:0.000}", result));
            result = 3.14159 * c * c;
            Console.WriteLine("CIRCULO: ", string.Format("{0:0.000}", result));
            result = ((a + b) * c) / 2;
            Console.WriteLine("TRAPEZIO: ", string.Format("{0:0.000}",result));
            result = b * b;
            Console.WriteLine("QUADRADO: ", string.Format("{0:0.000}", result));
            result = a * b;
            Console.WriteLine("RETANGULO: ", string.Format("{0:0.000}", result ));
        }
    }
}