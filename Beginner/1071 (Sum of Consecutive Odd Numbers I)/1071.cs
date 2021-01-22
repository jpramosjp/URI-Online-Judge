using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;
            int aux = 0;
            if(x > y)
            {
                aux = y;
                y = x;
                x = aux;
            }
         

            for (int i = x+1; i < y; i++)
            {
                
                if(i %2 ==1 || i % 2 == -1)
                {

                    soma += i;
                 
                }
               
            }

            Console.WriteLine(soma);
      
        }
    }
}