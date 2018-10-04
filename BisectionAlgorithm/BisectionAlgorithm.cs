using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    class BisectionAlgorithm
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int number = GetInput();
            int min = 0;
            int max = list.Length - 1;
            int compChoice;
            int count = 1;
            do
            {
                compChoice = GetCompChoice(min, max);
                Console.Write($"Attempt {count}: computer selected({list[compChoice]})\n");
                if (list[compChoice] < number)
                {
                    min = compChoice;
                    Console.WriteLine("computer choice is less than selected number");
                    count++;
                }
                else if(list[compChoice]>number)
                {
                    max = compChoice;
                    Console.WriteLine("Computer choice is greater than selected number");
                    count++;
                }
                
            } while (list[compChoice] != number);
            Console.WriteLine($"Number found. It took {count} tries to find it");
        }

        static int GetCompChoice(int min, int max)
        {
            int compChoice = min+((max - min) / 2);
            return compChoice;
        }

        private static int GetInput()
        {
            int input = 0;
            do
            {
                Console.WriteLine("Please enter a number 1-10");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (input<1||input>10);
            return input;
        }
    }
}
