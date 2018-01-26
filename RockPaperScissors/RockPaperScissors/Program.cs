using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string numberShoot;
            int CMP;
            int Rock = 1, Paper = 2, Scissor = 3;

            Random ranNumber = new Random();
            CMP = ranNumber.Next(1, 3);

            Console.WriteLine("Rock = 1, Paper = 2, Scissor = 3");
            numberShoot = Console.ReadLine();
            Rock = Convert.ToInt32(numberShoot)
            if (numberShoot == 1)
            {
                if (numberShoot == CMP)
                {
                   Console.WriteLine();
                }
                else
                {
                    // Condition1, Condition2, and Condition4 are false. Condition3 is true.
                }
            }
            else if (numberShoot == 2)
            {
                // Condition1 is false and Condition2 is true.
            }
            else if (numberShoot == 3)
            {
                if ()
                {
                    // Condition1 and Condition2 are false. Condition3 and Condition4 are true.
                }
                else
                {
                    // Condition1, Condition2, and Condition4 are false. Condition3 is true.
                }
            }
        }
    }
}
