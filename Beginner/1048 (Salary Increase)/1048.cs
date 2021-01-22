using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double percentual = 0.0;
            double reajuste = 0.0;
            double soma = 0.0;
         

            if(x > 0 && x<= 400.00)
            {
                percentual = 15;
                reajuste = x * (percentual / 100);
                soma = x + reajuste;
            }
            else if(x > 400.00 && x <= 800.00)
            {
                percentual = 12;
                reajuste = x * (percentual / 100);
                soma = x + reajuste;
            }
            else if (x > 800.00 && x <= 1200.00)
            {
                percentual = 10;
                reajuste = x * (percentual / 100);
                soma = x + reajuste;
            }
            else if (x > 1200.00 && x <= 2000.00)
            {
                percentual = 7;
                reajuste = x * (percentual / 100);
                soma = x + reajuste;
            }
            else if (x > 2000.00)
            {
                percentual = 4;
                reajuste = x * (percentual / 100);
                soma = x + reajuste;
            }

            Console.WriteLine("Novo salario: " + string.Format("{0:0.00}",soma));
            Console.WriteLine("Reajuste ganho: " + string.Format("{0:0.00}", reajuste));
            Console.WriteLine("Em percentual: " + string.Format("{0:0}", percentual) + " %");

        }
    }
}