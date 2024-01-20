using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            Console.Write("Enter Your Name:");
            String name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Instruction for Game");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Player \r\nstarts from 0 rolls the die to get a number between 1 to 6, finds \r\na safe place, ladder or a snake keeps doing till the winning spot \r\n100 is achieved.\r\n");
            int initalPosition = 0;
            int currentPosition = 0;
            Console.WriteLine($"{name}, Your Current Position is :{currentPosition}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's Begin the game : ");
            Console.WriteLine();
            Console.WriteLine("Type 'Start' to begin the game to Roll die");

            //    UC-2
            String input = Console.ReadLine();
            //ROlling Starts here
            if (input == "Start")
            {
                Random rand = new Random();
                int loopcounter = 0;
                while (currentPosition < 101)
                {

                    int rolling = rand.Next(1, 6);
                    Console.WriteLine("Your Rolling outcome is : " + rolling);

                    // UC-3


                    int decision = rand.Next(1, 3);
                    switch (decision)
                    {
                        case 1:
                            currentPosition += 0;
                            Console.WriteLine("Ah no you just hit nil");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition}");

                            break;
                        case 2:
                            currentPosition += rolling;
                            Console.WriteLine("You just ascend ladder");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition}");
                            break;
                        case 3:
                            currentPosition -= rolling;
                            Console.WriteLine("Oops snake bite you!");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition}");
                            break;
                    }

                    // UC-4
                    // while loop inserted
                    loopcounter++;
                    Console.WriteLine($"you rolled die {loopcounter} times");
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
        }
    }
}
