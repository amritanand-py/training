﻿using System;
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
<<<<<<< Updated upstream
=======
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
            String input = Console.ReadLine();
            //ROlling Starts here
            if ( input == "Start" ) {
                Random rand = new Random();
                int rolling = rand.Next(1, 6);
                Console.WriteLine("Your Rolling outcome is : "+ rolling);
            }
            

>>>>>>> Stashed changes
        }
    }
}
