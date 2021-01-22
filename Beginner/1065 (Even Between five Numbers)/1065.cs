using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int acm = 0;
            
            for(int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x % 2 == 0)
                {
                    acm++;
                }
               
            }

            Console.WriteLine(acm + " valores pares");
      
        }
    }
}