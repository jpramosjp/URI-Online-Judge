using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i < x + 1; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}