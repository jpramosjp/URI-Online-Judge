using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            
            Console.WriteLine("VOLUME = " + string.Format("{0:0.000}",(4.0 / 3) * 3.14159 * (r * r * r)));


        }
    }
}