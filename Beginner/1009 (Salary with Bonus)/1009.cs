using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double venda = double.Parse(Console.ReadLine());

            Console.WriteLine("TOTAL = R$ " + string.Format("{0:0.00}", venda * 0.15 + salario));


        }
    }
}