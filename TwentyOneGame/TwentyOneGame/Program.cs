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
            Deck deck = new Deck();

            ////Without Lambda expresion
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.ReadLine();

            ////With Lambda expression
            ////counting all the elements in the list (represented by x)
            ////where x.Face == Face.Ace
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            ////^<data type> <variable name> = <object><List><Built in Metho>
            ////=> map this expression to each item
            //Console.WriteLine(count);
            //Console.ReadLine();

            ////Another Lambda Example
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            //Console.ReadLine();

            ////Another Lambda Example
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 324, 21 };

            //int sum = numberList.Sum(x => +5);
            //int max = numberList.Max();
            //int min = numberList.Min();

            //Console.WriteLine("{0} {1} {2}", sum, max, min);
            //Console.ReadLine();

            ////struct vs. class
            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            ////Card as a struct would output card1.Face = Eight
            ////because it is a unique copy from card 2
            ////when card2.face was redefined, card1 was not impacted
            ////Card as a class would output card1.Face = King 
            ////because it is just a reference not a copy
            ////when card2.face was redefined, so was card1
            //Console.WriteLine(card1.Face);

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
