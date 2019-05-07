using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //by specifically stating abstract, you are in better control of the way these classes are used.
    public abstract class Game
    {
        //attributes of most games (generic as possible for changing requirements)
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        //can only exist in abstract clas
        //contains no implementation
        //any class inheriting this class, must inherit this method
        public abstract void Play();

        //method to list out players (print out to console)
        //use virtual keyword to modify method declared in the base class (game in this case) and allow it to be overridden in the derived class 
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
