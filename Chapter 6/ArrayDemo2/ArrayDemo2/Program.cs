using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[8];
            int x;
            string inputString;
            for (x = 0; x < score.Length; ++x)
            {
                Console.WriteLine("Enter your scores on test {0} ", x+1);
                inputString = Console.ReadLine();
                score[x] = Convert.ToInt32(inputString);
            }
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine();
            for (x = 0; )
            {
                Console.WriteLine(  );
            }
            Console.WriteLine("\n-------------------------------------");
            Array.Sort(score);
            Console.WriteLine();
            for ()
            {

            }
            Console.WriteLine("\n-------------------------------------");
            Array.Reverse();
            Console.WriteLine();
            for ()
            {

            }


        }
    }
}
