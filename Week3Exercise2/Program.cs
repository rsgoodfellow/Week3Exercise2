using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise2
{
    internal class Program
    {
        public static int[] RollDice() //method to generate the dice rolls
        {
            Random rnd = new Random(); //creates an random variable
            int[] dice = new int[2]; //creates an integer array with 2 array values
            dice[0] = rnd.Next(1,7); //simulates a dice roll for the first dice
            dice[1] = rnd.Next(1,7); //simulates a dice roll for the second dice
            return dice; //returns both dice values for RollDice()
        }

        static void Main(string[] args) //main method
        {
            bool roll = true; //creates a boolean variable and initializes it to true

            while (roll) //a while loop that will repeat as long as the boolean roll value equals true
            {
                int[] diceRolls = RollDice(); //creates an integer array that is equivilent to the RollDice method
                Console.WriteLine("You rolled a " + diceRolls[0] + " and a " + diceRolls[1] + "."); //displays dice rolls
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
