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
            //struct vs. class
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            //Card as a struct would output card1.Face = Eight
            //because it is a unique copy from card 2
            //when card2.face was redefined, card1 was not impacted
            //Card as a class would output card1.Face = King 
            //because it is just a reference not a copy
            //when card2.face was redefined, so was card1
            Console.WriteLine(card1.Face);

            ////enum example
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = (int)Suit.Diamonds;
            //Console.WriteLine(underlyingValue);
            ////

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();
            ////instantiate game object
            //Game game = new Game();
            //game.Dealer = "Kasi";
            //game.Name = "TwentyOne";

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            //THIS IS POLYMORPHISM
            //Game game = new TwentyOneGame();

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            ////using overload operator
            //game = game + player; //or += player
            //game -= player;

            
            ////instantiated an object from the class Deck and assigned it to variable deck
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

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
