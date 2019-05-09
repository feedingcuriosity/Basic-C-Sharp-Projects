using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExercise134
{
    class Program
    {
        static void Main(string[] args)
        {

            //2
            //prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            //3
            //Assign the value to a variable of that enum data type
            //a - determine userInput as string
            string userInput = Console.ReadLine().ToLower();
            //assign Days type to variable for Parse parameter
            Type dayType = typeof(Days);
            //4
            //wrap in a try/catch block
            try
            {
                //b - Parse userInput of string type
                Days day = (Days)Enum.Parse(dayType, userInput, true);
                Console.WriteLine("Today is " + day);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
