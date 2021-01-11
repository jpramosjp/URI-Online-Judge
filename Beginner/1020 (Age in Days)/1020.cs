using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i / 365 + " ano(s)"); i = i % 365;
            Console.WriteLine(i / 30 + " mes(es)"); i = i % 30;
            Console.WriteLine(i + " dia(s)");
        }
    }
}