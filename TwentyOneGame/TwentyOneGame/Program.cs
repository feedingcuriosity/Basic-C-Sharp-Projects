using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck (datatype) deck (name of variable)
            //instantiated an object Deck and assigned it to variable deck
            Deck deck = new Deck();
            //call the shuffle method (function)
            //named parameters make code more readable (deck, times)
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);

            //deck = Shuffle(deck, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //{0}, variable you want assigned
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
            

            //DONT NEED ANY OF THIS BECAUSE WE'RE GOING TO CREATE A CONSTRUCTOR
            //deck has a property Cards and Cards is a list
            //to create list, must do "new" (to instantiate it) List
            //deck.Cards = new List<Card>();         

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);
        }

        //default times value of 1, makes this an optional parameter
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for(int i=0; i<times; i++)
            {
                //each time we loop, add one to timesShuffled
                timesShuffled++;
                //empty temporty list of cards
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
            return deck;

        }

        ////When someone wants to shuffle more than once
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i=0; i<times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}


    }
}
