using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class NameChecker
    {
        public bool CheckNameFromUser(string name)
        {
            if (name == "" || !char.IsLetter(name[0]))
            {
                Console.WriteLine("This is an ileagel name.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
