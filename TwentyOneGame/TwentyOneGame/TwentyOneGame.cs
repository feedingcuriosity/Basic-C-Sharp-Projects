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
    public class TwentyOneGame : Game
    {
        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
