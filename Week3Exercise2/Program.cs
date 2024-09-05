using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise2
{
    internal class Program
    {
        private static Random rnd = new Random(); // Creates a random variable
        public static int RollDice() //method to generate the dice rolls
        {
            return rnd.Next(1,7); //returns dice values for RollDice()
        }

        static void Main(string[] args) //main method
        {
            bool roll = true; //creates a boolean variable and initializes it to true

            while (roll) //a while loop that will repeat as long as the boolean roll value equals true
            {
                int dice1 = RollDice();
                int dice2 = RollDice();
                Console.WriteLine("You rolled a " + dice1 + " and a " + dice2 + "."); //displays dice rolls
                Console.WriteLine("Would you like to roll again? (y/n)"); //prompts the user for input
                char input = Convert.ToChar(Console.ReadLine()); //applies user input to a new char variable
                if (input == 'y') //if condition for loop
                {
                    roll = true; //updates roll variable to true
                }
                else //else condition for loop
                {
                    roll = false; //updates roll variable to false
                }
            }
        }
    }
}
