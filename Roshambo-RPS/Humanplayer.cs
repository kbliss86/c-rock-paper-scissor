using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_RPS
{
    public class Humanplayer : Player
    {
        //sets human player name to Player.Name
        public Humanplayer(string name) : base(name, Roshambo.RoshamboValues.Rock) { }
        public override Roshambo.RoshamboValues GenerateRoshambo()
        {
            bool validChoice = false;
            Roshambo.RoshamboValues choice = Roshambo.RoshamboValues.Rock;
            while (!validChoice)
            {
                //Prompt user for input
                Console.WriteLine("Rock, Paper, or Scissors? (R/P/S): ");
                //Read user input
                string userInput = Console.ReadLine().ToLower();



                //Switch statement to validate user input
                switch (userInput)
                {
                    //If r then return roshambo.roshambovalues.rock and validChoice = true
                    case "r":
                        choice = Roshambo.RoshamboValues.Rock;//Not sure how the return works here
                        validChoice = true;
                        break;
                    case "p":
                        choice = Roshambo.RoshamboValues.Paper;//Not sure how the return works here
                        validChoice = true;
                        break;
                    case "s":
                        choice = Roshambo.RoshamboValues.Scissors;//Not sure how the return works here
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            return choice;
        }
    }//End Class

}//End Namespace
