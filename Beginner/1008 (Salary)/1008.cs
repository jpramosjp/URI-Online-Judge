using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("NUMBER = " + number );
            Console.WriteLine("SALARY = U$ " +string.Format("{0:0.00}", salary * hours));


        }
    }
}