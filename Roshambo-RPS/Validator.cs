using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo_RPS
{
    public class Validator
    {
        //Method to validate Y/N input
        public static bool ValidateYorN(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (input == "Y" || input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "N" || input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                return false;
            }
        }

        public static Player GetPlayer(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            if (input == "Rock Player")
            {
                return new Rockplayer();
            }
            else if (input == "Random Player")
            {
                return new Randomplayer();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter Rock Player or Random Player");
                return new Randomplayer(); // This will be the default!
            }
        }
    }
}
