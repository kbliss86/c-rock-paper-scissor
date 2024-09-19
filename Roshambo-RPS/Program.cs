using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            //Get Human Players Name
            Console.WriteLine("Whats your NAAAAME");
            string playerName = Console.ReadLine();

            //Create Human Player
            Humanplayer humanPlayer = new Humanplayer(playerName);

            //User Chooses opponent
            Player opponent = Validator.GetPlayer("Would you like to play against Rock Player or Random Player?");

            //bool for continue playing
            bool continuePlaying = true;
            //while loop for game
            while(continuePlaying)
            {
                //Get human player choice
                humanPlayer.Choice = humanPlayer.GenerateRoshambo();
                //Get opponent choice
                opponent.Choice = opponent.GenerateRoshambo();

                //Print choices
                Console.WriteLine($"{humanPlayer.Name} chose {humanPlayer.Choice}");
                Console.WriteLine($"{opponent.Name} chose {opponent.Choice}");

                //Determine winner
                string winner = Player.DetermineWinner(humanPlayer, opponent);

                //Print winner
                Console.WriteLine(winner);

                //Ask user if they want to play again
                continuePlaying = Validator.ValidateYorN("Do you want to play again? (Y/N)");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
