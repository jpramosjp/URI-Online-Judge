using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int acm = 0;
            for (int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine());
                if (n > 0)
                {
                    acm++;
                }
            }

            Console.WriteLine(acm + " valores positivos");
        }
    }
}