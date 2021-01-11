using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(n / 3600 + ":"); n = n % 3600;
            Console.Write(n / 60 + ":"); n = n % 60;
            Console.WriteLine(n);
        }
    }
}