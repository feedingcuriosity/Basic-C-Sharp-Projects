using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //Create interface because you can only inherit from one class
    //Supports multiple inheritance from interfaces
    //everything is public in an interface
    //naming convention is to start with uppercase I
    interface IWalkAway
    {
        void WalkAway(Player player);
    }
}
