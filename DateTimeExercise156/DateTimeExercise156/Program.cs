using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise156
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //create variable now of datatype DateTime
            DateTime now = DateTime.Now;
            //Prints the current date and time to the console
            Console.WriteLine(now);
            //2
            //Ask the user for a number
            Console.WriteLine("Please provide a number:");
            //store input as variable type integer
            int userInput = Convert.ToInt32(Console.ReadLine());
            //3
            //prints to the console the exact time it will be in userInput hours
            Console.WriteLine(now.AddHours(userInput));
            Console.ReadLine();

        }
    }
}
