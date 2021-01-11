using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = Console.ReadLine().Split(' ');
            int a = int.Parse(texto[0]), b= int.Parse(texto[1]),c = int.Parse(texto[2]);

            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " eh o maior");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b + " eh o maior");
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine(c + " eh o maior");
            }


        }
    }
}