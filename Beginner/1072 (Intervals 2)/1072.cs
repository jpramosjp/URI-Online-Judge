using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int acmIn = 0;
            int acmOut = 0;
         

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    acmIn++;
                }
                else
                {
                    acmOut++;
                }
               
            }

            Console.WriteLine(acmIn + " in");
            Console.WriteLine(acmOut + " out");

        }
    }
}