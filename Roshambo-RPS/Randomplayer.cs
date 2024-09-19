using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_RPS
{
    //Sub Class of Player
    public class Randomplayer : Player
    {
        //Create player with fixed anme and choice
        public Randomplayer() : base("RandomPlayer", Roshambo.RoshamboValues.Rock)
        {
        }

        public override Roshambo.RoshamboValues GenerateRoshambo()
        {
            Random random = new Random();
            int randomChoice = random.Next(1, 4);
            switch (randomChoice)
            {
                case 1:
                    return Roshambo.RoshamboValues.Rock;
                case 2:
                    return Roshambo.RoshamboValues.Paper;
                case 3:
                    return Roshambo.RoshamboValues.Scissors;
                default:
                    return Roshambo.RoshamboValues.Rock;
            }
        }
    }//End Class
}//End NameSpace
