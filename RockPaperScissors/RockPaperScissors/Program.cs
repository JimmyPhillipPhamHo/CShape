﻿using System;
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

            /*string Shoot;
            int randNumber;
            int Rock = 1, Paper = 2, Scissor = 3, Score = 0;

            Random ranNumber = new Random();
            CMP = ranNumber.Next(1, 3);

            Console.WriteLine("Rock = 1, Paper = 2, Scissor = 3");
            Shoot = Console.ReadLine();
            Rock = Convert.ToInt32(Shoot)
           
            while (Score)
            
            if (Shoot == 1)
            {
                if (Shoot == CMP)
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
            }*/
            Console.WriteLine("Do you choose rock,paper or scissors");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose,paper beat rock");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,scissors beat paper ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,rock beats scissors");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,rock beats scissors");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,paper beats rock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            Console.ReadLine();
        }
    }
}
