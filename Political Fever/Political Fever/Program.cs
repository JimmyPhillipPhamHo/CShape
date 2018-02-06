using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Political_Fever
{
    class Program
    {
        static void Main(string[] args)
        {
            string TD, C1, C2;
            int Delegates;
            double Candidate1, Candidate2, Candidate3;
            Console.Write("Enter the total of Delegates ");
            TD = Console.ReadLine();
            Delegates = Convert.ToInt32(TD);
            Console.Write("Enter the percent of votes Candidate 1 has ");
            C1 = Console.ReadLine();
            Candidate1 = Convert.ToDouble(C1);
            Console.Write("Enter the percent of votes Candidate 2 has ");
            C2 = Console.ReadLine();
            Candidate2 = Convert.ToDouble(C2);


            Candidate3 = (Delegates - (Delegates * (Candidate1 + Candidate2))) / Delegates;

            if (Candidate1 < .15 && Candidate1 > 50 || Candidate2 < .15 && Candidate2 > 50 || Candidate3 < .15 && Candidate3 > 50)
            {
                 if (Candidate1 < .15)
                {
                    Candidate1 = (Candidate1 * Delegates) / 2;
                    Candidate2 = Candidate1 + (Candidate2 * Delegates);
                    Candidate3 = Candidate1 + (Candidate3 * Delegates);
                    Candidate1 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
                if (Candidate2 < .15)
                {
                    Candidate2 = (Candidate2 * Delegates)/2;;
                    Candidate1 = Candidate2 + (Candidate1 * Delegates);
                    Candidate3 = Candidate2 + (Candidate3 * Delegates);
                    Candidate2 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
                if (Candidate3 < .15)
                {
                    Candidate3 = (Candidate3 * Delegates)/2;
                    Candidate1 = Candidate3 + (Candidate1 * Delegates);
                    Candidate2 = Candidate3 + (Candidate2 * Delegates);
                    Candidate3 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
            }
            else if (Candidate1 > .50 || Candidate2 > .50 || Candidate3 > .50)
            {
                if (Candidate1 > .50)
                {
                    Candidate1 = (Candidate1 * Delegates) + (Candidate2 * Delegates) + (Candidate3 * Delegates);
                    Candidate2 = 0;
                    Candidate3 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
                if (Candidate2 > .50)
                {
                    Candidate2 = (Candidate2 * Delegates) + (Candidate1 * Delegates) + (Candidate3 * Delegates);
                    Candidate1 = 0;
                    Candidate3 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
                if (Candidate3 > .50)
                {
                    Candidate3 = (Candidate3 * Delegates) + (Candidate1 * Delegates) + (Candidate2 * Delegates);
                    Candidate1 = 0;
                    Candidate2 = 0;
                    Console.WriteLine("Candidate 1: " + Candidate1);
                    Console.WriteLine("Candidate 2: " + Candidate2);
                    Console.WriteLine("Candidate 3: " + Candidate3);
                }
            }
            else
            {
                Candidate1 = Candidate1 * Delegates;
                Candidate2 = Candidate2 * Delegates;
                Candidate3 = Candidate3 * Delegates;
                Console.WriteLine("Candidate 1: " + Candidate1);
                Console.WriteLine("Candidate 2: " + Candidate2);
                Console.WriteLine("Candidate 3: " + Candidate3);
            }

            



        }
    }
}
