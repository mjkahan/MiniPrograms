using System;
using System.Collections.Generic;
using System.Text;

namespace MiniPrograms
{
    class SumGame
    {
        public static void AskQuestion()
        {
            Top:
            Random random = new Random();
            int num = random.Next(10, 100);
            int answer = (num / 10) + (num % 10);

            Console.WriteLine("What is the sum of the two digits in the value " + num.ToString() + "?");

            Start:
            string response = Console.ReadLine();

            if (answer.ToString() == response)
            {
                Console.WriteLine("You are correct!");
                Console.Write("Play again? (Y/N) ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    goto Top;
                }
                else
                {
                    Console.WriteLine("Okay, goodbye!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(1);
                }
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect. Guess again.");
                goto Start;
            }            
        }
    }
}
