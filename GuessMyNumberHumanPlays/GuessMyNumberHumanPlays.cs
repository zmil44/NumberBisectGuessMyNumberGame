using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberHumanPlays
{
    class GuessMyNumberHumanPlays
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int winningNumber = rand.Next(1, 1001);
            int guess;
            int count=1;
            do
            {
                guess = GetGuess();
                if(guess==winningNumber)
                {
                    Console.WriteLine("You selected the winning number");
                    count++;
                }
                else if(guess<winningNumber)
                {
                    Console.WriteLine("Your guess is less than the winning number");
                    count++;

                }
                else
                {
                    Console.WriteLine("Your guess is higher than the winning number");
                    count++;
                }
            } while (guess != winningNumber);
            Console.WriteLine($"You selected the winning number in {count} attempts");
        }

        private static int GetGuess()
        {
            int guess=0;
            do
            {
                Console.WriteLine("Enter your guess: ");
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (guess < 1 || guess > 1000);
            return guess;

        }
    }
}
