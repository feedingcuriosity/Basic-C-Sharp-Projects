using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //class = model or template
    public class Card
    {
        
        //suit, face, (value, color) 
        //give card class a property called "suit"
        //get and set are the only things you can do with the property suit with data type string
        //public means it's accessible to other parts of the program
        public string Suit { get; set; }
        public string Face { get; set; }
        //public int Value { get; set; }

        //Constructor to assign default values
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
    }  
}
