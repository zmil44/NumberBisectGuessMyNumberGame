using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberComputerPlays
{
    class GuessMyNumberComputerPlays
    {
        static void Main(string[] args)
        {

            int winningNumber = GetWinningNumber();
            int guess;
            int count = 1;
            int min = 0;
            int max = 1000;
            string information;
            const string equal = "equal";
            const string higher = "higher";
            const string lower = "lower";
            do
            {
                guess = GetGuess(min,max);
                Console.WriteLine($"The computer guesses {guess}");
                Console.WriteLine("Is the computer's guess higher, lower, or equal to the winning number?");
                do
                {
                    information = Console.ReadLine();
                    information = information.ToLower();
                } while (information != "equal" && information != "higher" && information != "lower");
                if (information.Equals("equal"))
                {
                    Console.WriteLine($"The computer selected the winning number in {count} attempts");
                }
                   
                else if (information.Equals("lower"))
                {
                    min = guess;
                    count++;

                }
                else
                {
                    max = guess;
                    count++;
                }
            } while (guess != winningNumber);
            Console.WriteLine($"You selected the winning number in {count} attempts");
        }

        private static int GetGuess(int min, int max)
        {
            int compChoice = min + ((max - min) / 2);
            return compChoice;
        }

        private static int GetWinningNumber()
        {
            int winningNumber = 0;
            do
            {
                Console.WriteLine("Enter the winning number ");
                try
                {
                    winningNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (winningNumber < 1 || winningNumber > 1000);
            return winningNumber;

        }
    }
}
