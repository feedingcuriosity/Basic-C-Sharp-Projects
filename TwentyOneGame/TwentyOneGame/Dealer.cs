using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Dealer
    {
        //Dealer propertiess
        //prop tab tab 
        public string Name { get; set; }
        //Deck is a class property (composition - do this when in doubt), not inherited, because a dealer HAS-A deck. It's not that the dealer IS-A deck.
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //Dealer Methods
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }

    }
}
