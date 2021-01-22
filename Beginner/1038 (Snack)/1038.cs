using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');

            int x = int.Parse(texto[0]);
            int y = int.Parse(texto[1]);

           if (x == 3)
            {
                Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", y * 5.00));
            }
           else if (x == 1)
            {
                Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", y * 4.00));
            }
           else if (x == 2)
            {
                Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", y * 4.50));
            }
           else if (x == 4)
            {
                Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", y * 2.00));
            }
           else if (x == 5)
            {
                Console.WriteLine("Total: R$ " + string.Format("{0:0.00}", y * 1.50));
            }
        }
    }
}