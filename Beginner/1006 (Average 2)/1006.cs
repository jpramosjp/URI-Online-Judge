﻿using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("MEDIA = " + string.Format("{0:0.0}",((a*2 + b*3 + c*5)/10)));


        }
    }
}