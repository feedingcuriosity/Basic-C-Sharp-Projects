using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //syntax for inheritence = : <class you want to inherit from>
    //Once this is complete, all the properties and methods from the Game class will be 
    //accessible from the twentyonegame class
    //this also gives you the opporutnity to make unique properties and methods
    //for this more specific class
    public class TwentyOneGame : Game, IWalkAway
    {
        //This play method must be here or the compiler would throw an error message
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            //automatically filled in
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
