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
            //int rolling = letsroll();
            int currentPosition1 = 0;
            int currentPosition2 = 0;
            Console.WriteLine($"{name}, Your Current Position is :{currentPosition1}");
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
                while (currentPosition1 != 100)
                {

                    Console.WriteLine("Player 1 turn: ");
                    Console.WriteLine();
                    Console.WriteLine();

                    
                    int rolling1 = rand.Next(1, 7);
                    Console.WriteLine("Your Rolling outcome is : " + rolling1);


                    // UC-3


                    int decision = rand.Next(1, 4);
                    switch (decision)
                    {
                        case 1:
                            currentPosition1 += 0;
                            Console.WriteLine("Ah no you just hit nil");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition1}");

                            break;
                        case 2:

                            if ((currentPosition1 + rolling1) <= 100)
                            {
                                currentPosition1 += rolling1;
                            }

                            Console.WriteLine("You just ascend ladder");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition1}");
                            break;
                        case 3:
                            currentPosition1 -= rolling1;
                            Console.WriteLine("Oops snake bite you!");
                            if (currentPosition1 < 0)
                            {
                                currentPosition1 = 0;
                            }
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition1}");
                            break;
                    }

                    // UC-4
                    // while loop inserted
                    loopcounter++;
                    Console.WriteLine($"you rolled die {loopcounter} times");
                    Console.WriteLine();
                    Console.WriteLine();

                    // 2nd player setup


                    Console.WriteLine("Player 2 turn: ");
                    Console.WriteLine();
                    Console.WriteLine();

                    
                    int rolling2 = rand.Next(1, 7);
                    Console.WriteLine("Your Rolling outcome is : " + rolling2);


                    // UC-3


                    int decision2 = rand.Next(1, 4);
                    switch (decision2)
                    {
                        case 1:
                            currentPosition2 += 0;
                            Console.WriteLine("Ah no you just hit nil");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition2}");

                            break;
                        case 2:

                            if ((currentPosition2 + rolling2) <= 100)
                            {
                                currentPosition2 += rolling2;
                            }

                            Console.WriteLine("You just ascend ladder");
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition2}");
                            break;
                        case 3:
                            currentPosition2 -= rolling2;
                            Console.WriteLine("Oops snake bite you!");
                            if (currentPosition2 < 0)
                            {
                                currentPosition2 = 0;
                            }
                            Console.WriteLine($"{name}, now Current Position is :{currentPosition2}");
                            break;
                    }

                    // UC-4
                    // while loop inserted
                  
                    
                    if (currentPosition1 == 100)
                    {
                        Console.WriteLine("Player 1 won");
                    }
                    else if(currentPosition2 == 100)
                    {
                        Console.WriteLine("Player 2 won");
                    }
                    else
                    {
                        Console.WriteLine("Game will go to another turn");
                    }

                    Console.WriteLine($"you rolled die {loopcounter} times");
                    Console.WriteLine();
                    Console.WriteLine();



                }
            }
            }

        /*static int letsroll()
        {
            Random rand = new Random();
            int rolling = rand.Next(1, 7);
            Console.WriteLine("Your Rolling outcome is : " + rolling);
            return rolling;
        }*/

    }


        


    }

