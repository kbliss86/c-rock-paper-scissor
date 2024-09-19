using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roshambo_RPS
{
    //Sub Class of Player
    //Always throws rocks - no user supplied name
    public class Rockplayer : Player
    {
        //Default Constructor
        public Rockplayer() : base("TheBoulder", Roshambo.RoshamboValues.Rock)
        {
        }

        public override Roshambo.RoshamboValues GenerateRoshambo()
        {
            return Roshambo.RoshamboValues.Rock;
        }
    }
}
