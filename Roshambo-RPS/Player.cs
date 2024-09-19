using Roshambo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_RPS
{
    public abstract class Player
    {
        private string name;
        private Roshambo.RoshamboValues choice;//Confusing using upper/lower for private/public
        public string Name { get { return name; } } //No Setter Defined, read only Property
        public Roshambo.RoshamboValues Choice//Confusing using upper/lower for private/public 
        { 
            get { return choice; }
            set { choice = value; } 
        }

        public Player(string name, Roshambo.RoshamboValues choice)
        {
            this.name = name;
            this.choice = choice;
        }

        public abstract Roshambo.RoshamboValues GenerateRoshambo();

        //Method for the game and determining the winnder
        public static string DetermineWinner(Player player1, Player player2)
        {
            //Choices from both players
            Roshambo.RoshamboValues choice1 = player1.Choice;
            Roshambo.RoshamboValues choice2 = player2.Choice;

            //check for tie
            if (choice1 == choice2)
            {
                return "It's a tie!";
            }
            //Check Win Conditions
            if ((choice1 == Roshambo.RoshamboValues.Rock && choice2 == Roshambo.RoshamboValues.Scissors) ||
            (choice1 == Roshambo.RoshamboValues.Paper && choice2 == Roshambo.RoshamboValues.Rock) ||
            (choice1 == Roshambo.RoshamboValues.Scissors && choice2 == Roshambo.RoshamboValues.Paper))
            {
                return player1.Name + " wins!";
            }
            else
            {
                return player2.Name + " wins!";
            }
        }
    }
}
