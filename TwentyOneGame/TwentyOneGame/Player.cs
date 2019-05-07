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

    }
}
