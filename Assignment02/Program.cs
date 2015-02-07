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
