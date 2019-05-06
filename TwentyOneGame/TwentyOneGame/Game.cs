using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Game
    {
        //attributes of most games (generic as possible for changing requirements)
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //method to list out players (print out to console)
        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
