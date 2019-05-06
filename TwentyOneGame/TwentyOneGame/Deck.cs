using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{   //Why even create a deck class?
    //1 - because we made a constructor to even create the first deck and;
    //2 - objects don't just have properties, they also have behavior or do things
    public class Deck
    {
        //Create constructor (always goes at the top of class)
        //Constructor name is always the name of the class
        public Deck()
        {
            //instantiate the object in the constructor as an empty list to assign values later
            Cards = new List<Card>();
            //first, create a list of all possible suits
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    //note that card only exists in this loop and that's why
                    //we can create it over and over again
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
            
            //Here's the long way, you would do this for everycard in the deck
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


        }
        
        //deck is a collection of the cards class
        //public property of data type list 
        //list of cards
        public List<Card> Cards { get; set; }
    }
}
