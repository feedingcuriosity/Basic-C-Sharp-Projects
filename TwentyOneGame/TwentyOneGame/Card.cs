using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //class = model or template
    public struct Card
    {

        //give card class a property called "suit"
        //get and set are the only things you can do with the property suit with data type string
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        
    }
    //defining an enum is similiar to defining a class and good practice is to have it as a separate file
    public enum Suit
    {
        Clubs, 
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
