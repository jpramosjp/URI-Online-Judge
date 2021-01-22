using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int acmPar = 0;
            int acmImpar = 0;
            int acmPositivo = 0;
            int acmNegativo = 0;
           
            for(int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    acmPositivo++;
                }
                else if(x < 0)
                {
                    acmNegativo++;
                }
                if(x % 2 == 0)
                {
                    acmPar++;
                }
                else
                {
                    acmImpar++;
                }
            }

            Console.WriteLine(acmPar + " valor(es) par(es)");
            Console.WriteLine(acmImpar + " valor(es) impar(es)");
            Console.WriteLine(acmPositivo + " valor(es) positivo(s)");
            Console.WriteLine(acmNegativo + " valor(es) negativo(s)");
        }
    }
}