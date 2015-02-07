///------------------------------------------------------------------------------------------
///   Project:              Assignment 02 - The SuperHero Class
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   Februrary 06, 2015
///   
///   Program description:  A program that creates a hero class and makes the hero fight
///                         while displaying the damage done if the hit lands on the target
///                         
///   Revision History:     2015-02-06: Added a SuperHero class
///                         2015-02-06: Completed the SuperHero class
///                         2015-02-06: Completed the main method and tested the program
///                         2015-02-06: Polished the program by adding an unlimited fight mode
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superGoat = new SuperHero("Super Goat");

            superGoat.showPowers();
            Console.WriteLine("Press the spacebar to hit the target. Press any other key to quit you coward.");

            // lets the user fight as long as they want
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    superGoat.fight();
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
