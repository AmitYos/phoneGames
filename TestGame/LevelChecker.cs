using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class LevelChecker
    {
        public bool CheckLevelFromUser(string level)
        {
            if (level != "l" & level != "m" & level != "h")
            {
                Console.WriteLine("This is an ileagel level.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
