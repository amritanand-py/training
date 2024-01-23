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
            int rolling = letsroll();
            int currentPosition = 0;
            Console.WriteLine($"{name}, Your Current Position is :{currentPosition}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let's Begin the game : ");
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to begin the game to Roll die");
            Random rand = new Random();

            //    UC-2
            String input = Console.ReadLine();
            //ROlling Starts here
            if (input == "")
            {
                
                int loopcounter = 0;
                while (currentPosition != 100)
                {

                    letsroll();


                    // UC-3


                    int decision = rand.Next(1, 4);
                    switch (decision)
                    {
                        case 1:
                            currentPosition += 0;
                            Console.WriteLine("Ah no you just hit nil");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition}");

                            break;
                        case 2:
                   
                           if ((currentPosition+rolling) <= 100)
                            {
                                currentPosition += rolling;
                            }
                           
                            Console.WriteLine("You just ascend ladder");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition}");
                            break;
                        case 3:
                            currentPosition -= rolling;
                            Console.WriteLine("Oops snake bite you!");
                            if (currentPosition < 0)
                            {
                                currentPosition = 0;
                            }
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


        static int letsroll()
        {
            Random rand = new Random();
            int rolling = rand.Next(1, 7);
            Console.WriteLine("Your Rolling outcome is : " + rolling);
            return rolling;
        }


    }
}
