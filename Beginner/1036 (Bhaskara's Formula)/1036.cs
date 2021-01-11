using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            double a= double.Parse(texto[0]), b = double.Parse(texto[1]), c = double.Parse(texto[2]);
            double result;
            double delta = (b * b) - 4 * (a * c);
            if(a <=0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                result = ((-b) + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R1 = " + string.Format("{0:0.00000}",result));
                result = ((-b) - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("R2 = " + string.Format("{0:0.00000}", result));
            }
        }
    }
}