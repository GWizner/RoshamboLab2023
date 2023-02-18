using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RoShamBoLab2023
{
    public class Validator
    {
        internal static Player.Roshambo GetPlyr(string newName)
        {
            while (true)
            {
                Console.WriteLine("Okay, " + newName + " choose your weapon: ");
                string userInput = Console.ReadLine();

                Player.Roshambo plyrAtk;

                if (Enum.TryParse<Player.Roshambo>(userInput, true, out plyrAtk))
                {
                    return plyrAtk;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter Rock, Paper, or Scissors.\n");
                    return 0;
                }
            }
        }
        internal static int GetOpp(HumanPlayer player1, Player opponent, Player.Roshambo oppAtk, Player.Roshambo plyrAtk, int wins)
        {
            bool goodOpp = false;
            bool? winLoss = true;
            int ReadyPlayerOne = 0;

            while (!goodOpp)
            {
                Console.WriteLine($"\n{player1.newName}, are you ready? Choose your opponent (Input 1 for RockPlayer" +
                        $" or input 2 for RandomPlayer): ");
                string userInput = Console.ReadLine();
                goodOpp = int.TryParse(userInput, out ReadyPlayerOne);
                Console.WriteLine();

                if (goodOpp)
                {
                    if (ReadyPlayerOne == 1)
                    {
                        opponent = new RockPlayer();
                        oppAtk = opponent.GenerateRoshambo();
                    }
                    else if (ReadyPlayerOne == 2)
                    {
                        opponent = new RandomPlayer();
                        oppAtk = opponent.GenerateRoshambo();
                    }
                    else 
                    {
                        Console.WriteLine("Not a valid choice. Try again");
                        goodOpp = false;
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid choice. Try again");
                }
            }
            if (oppAtk == plyrAtk)
            {
                winLoss = null;
            }
            else if (oppAtk == Player.Roshambo.Rock && plyrAtk == Player.Roshambo.Paper)
            {
                winLoss = true;
            }
            else if (oppAtk == Player.Roshambo.Rock && plyrAtk == Player.Roshambo.Scissors)
            {
                winLoss = false;
            }
            else if (oppAtk == Player.Roshambo.Paper && plyrAtk == Player.Roshambo.Rock)
            {
                winLoss = false;
            }
            else if (oppAtk == Player.Roshambo.Paper && plyrAtk == Player.Roshambo.Scissors)
            {
                winLoss = true;
            }
            else if (oppAtk == Player.Roshambo.Scissors && plyrAtk == Player.Roshambo.Rock)
            {
                winLoss = true;
            }
            else if (oppAtk == Player.Roshambo.Scissors && plyrAtk == Player.Roshambo.Paper)
            {
                winLoss = false;
            }
            if (winLoss == true)
            {
                Console.WriteLine($"{plyrAtk} vs. {oppAtk}!");
                Console.WriteLine("You win!");
                wins++;
            }
            else if (winLoss == false)
            {
                Console.WriteLine($"{plyrAtk} vs. {oppAtk}!");
                Console.WriteLine("Looks like you lost this one.");
            }
            else 
            {
                Console.WriteLine($"{plyrAtk} vs. {oppAtk}!");
                Console.WriteLine("It's a tie.");
            }
            return wins;
        }
        public static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine();
                Console.Write("You ready for more? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                choice = choice.Trim();
                Console.WriteLine();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I do not understand your input. Please try again.\n");
                }
            }
            return result;
        }
    }
}