using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for(int i = 0; i < 6; i++)
            {
               if(x % 2 == 0)
                {
                    x++;
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine(x);
                }
                x += 2;
            }
        }
    }
}