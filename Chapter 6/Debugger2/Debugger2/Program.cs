﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 15, 22, 88 };
            int x;
            double average;
            double total = 0;
            Console.Write("The numbers are...");
            for (x = 0; x < numbers.Length; ++x)
            {
                Console.Write("{0, 6}", numbers[x]);
            }
            Console.WriteLine();
            for (x = 0; x < numbers.Length; ++x)
            {
                total = numbers.Sum();
                
            }
            average = total / numbers.Length;
            Console.Write("The average is " + average);
            Console.WriteLine();
        }
    }
}
