using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        public List<Card> hand { get; set; }
        public int Balance { get; set; }
        //prop tab tab
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //overloading an operator. syntax:
            //access specifier  className  operator Operator_symbol (parameters)
                //{
                    // Code
                //}
        public static Game operator+ (Game game, Player player)
        {
            //note, game is the objec t
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
