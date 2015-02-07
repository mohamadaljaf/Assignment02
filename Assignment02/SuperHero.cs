///------------------------------------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   February 06, 2015
///   
///   Class description:    A SuperHero object has the random super powers. Is a child class of
///                         the Hero class and therefore inherits its methods.
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    // SuperHero sublcass of Hero class
    class SuperHero : Hero
    {
        // PRIVATE Properties ********************/
        private string[] superPowers;

        // CONSTRUCTOR ********************/
        public SuperHero(string name)
            : base(name)
        {
            this.generateAbilities();
        }

        // PUBLIC Methods ********************/
        // displays the SuperHero's powers to the console
        public void showPowers()
        {
            Console.WriteLine("The Superhero {0} has: \n\t{1}  \n\t{2}  \n\t{3}", this.name, this.superPowers[0],
                this.superPowers[1], this.superPowers[2]);
        }

        // PRIVATE Methods ********************/
        // randomly generates the hero's super powers from a list of 6 powers
        private void generateAbilities()
        {
            List<string> tempPowers = new List<string>();
            string[] powersList = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            Random randomGenerator = new Random();
            int randomNum;

            do
            {
                randomNum = randomGenerator.Next(0, 6);

                // if the string array tempPowers does not contain the random super power from the powerslist then add it
                if (!tempPowers.Contains(powersList[randomNum]))
                {
                    tempPowers.Add(powersList[randomNum]);
                }
            } while (tempPowers.Count < 3);

            superPowers = tempPowers.ToArray();
        }
    }
}
