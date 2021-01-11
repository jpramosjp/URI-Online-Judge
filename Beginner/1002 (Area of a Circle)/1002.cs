using System;

namespace URI
{
    class URI
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double area = 3.14159 * (raio * raio);

            Console.WriteLine("A=" + string.Format("{0:0.0000}", area));
        }
    }
}