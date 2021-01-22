using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int acm = 0;
            double aux =  0;
            for (int i = 0; i < 6; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    acm++;
                    aux += x;
                }
            }

      
            Console.WriteLine(acm + " valores positivos");
            Console.WriteLine(string.Format("{0:0.0}", aux/acm)) ;
        }
    }
}