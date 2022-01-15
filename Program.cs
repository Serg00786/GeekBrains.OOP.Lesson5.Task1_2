﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson5.Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber();
            ComplexNumber c2 = new ComplexNumber();
            c1.r = 4;
            c1.i = 3;
            c2.r = 4;
            c2.i = 4;

            var sum = c1 + c2;
            var sub = c1 - c2;
            var mul = c1 * c2;

            Console.WriteLine(mul.ToString());

            Console.WriteLine("c1.Equals(c2) = {0}", c1.Equals(c2));
            Console.WriteLine("c1 == c2 = {0}", c1 == c2);
            Console.WriteLine("c1 != c2 = {0}", c1 != c2);

            Console.ReadLine();

        }
    }
}
