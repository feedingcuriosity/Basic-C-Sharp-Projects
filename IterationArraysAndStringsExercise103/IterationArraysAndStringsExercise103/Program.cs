using System;
using System.Collections.Generic;


namespace IterationArraysAndStringsExercise103
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Create a one-dimensional array of strings
            string[] friends = new string[4];
            //Create a loop 
            for (int i = 0; i < friends.Length; i++)
            {   //ask user to input text
                Console.WriteLine("Please enter your #" + (i + 1) + " friends name:");
                //go throuhg each string in the array, adding the user's text to the string.
                friends[i] = Console.ReadLine();

            }

            //Create a loop that prints off each string in the Array on a separate line
            //heading
            Console.WriteLine("Your top 4 friends are:");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine(friends[i]);

            }
            Console.ReadLine();

            //  2 & 3 - Create an infinite loop that will execute [note: can also use while (true)]
            for (; ; )
            {
                Console.WriteLine("Infinity");
                if (Console.KeyAvailable)
                {
                    break;
                }
            }

            //4
            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator.
            for (int a = 20; a < 40; a++)
            {
                Console.WriteLine("iterate 20 times");
            }
            Console.ReadLine();

            //5
            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator.
            for (int a = 20; a <= 40; a++)
            {
                Console.WriteLine("iterate 21 times");
            }
            Console.ReadLine();

            //6
            //Create a list of strings where each item in the list is unique.
            List<string> fruits = new List<string>() { "avacado", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew", "indian plum", "jackfruit", "kiwi", "lime", "mango", "nectarine", "orange", "pineapple" };
            //Ask the user to select text to search for in the list.
            Console.WriteLine("Guess a fruit from the list with fruits starting with 'a' to 'p'.");
            //retrieve the user's input
            string fruitSelection = (Console.ReadLine());
            //Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits.Contains(fruitSelection))
                {
                    if (fruitSelection == fruits[i])
                    {
                        Console.WriteLine("You selected a fruit from the list! " + fruits[i] + " is located at index " + i);
                        //8 - stop from executing once a match has been found
                        i = fruits.Count;
                    }
                }
                //7- tell the user if they put in text that isn't in the list.
                else
                {
                    Console.WriteLine("Sorry, you have not selected a fruit from the list.");
                    i = fruits.Count;
                }

            }

            Console.ReadLine();


            //9
            //Create a list of strings that has at least two identical strings in the list.
            List<string> rainbow = new List<string>() { "red", "red", "orange", "yellow", "green", "blue", "purple" };
            //Ask the user to select text to search for in the list. 
            Console.WriteLine("Please select a color from the rainbow.");
            //get user input
            string rainbowSelection = Console.ReadLine();
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            for (int i = 0; i < rainbow.Count; i++)
            {
                if (rainbow.Contains(rainbowSelection))
                {
                    if (rainbowSelection == rainbow[i])
                    {
                        Console.WriteLine(rainbow[i] + " is located at index " + i);
                    }

                }
                //10 - telll user if they put in text that isn't in the list
                else
                {
                    Console.WriteLine("Sorry, that color is not in this rainbow.");
                    i = rainbow.Count;
                }


            }
            Console.ReadLine();

            //11 
            //Create a List of strings that has at least two identical strings in the List.
            List<string> flowers = new List<string>() { "rose", "lilly", "bluebell", "gardenia", "lavendar", "sweet pea", "bluebell", "lilly", "rose", "wallflower" };

            //Create a comparison dictionary 
            var comparison = new Dictionary<string, int>();
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string flower in flowers)
            {
                Console.WriteLine(flower);
                if (comparison.ContainsKey(flower))
                {
                    Console.WriteLine("Already appeared in the list.");
                    //only unique values in dictionary, this modifies the value to 2.
                    //The value of 1 is provided in else statement then ++ adds one to the value.
                    comparison[flower]++;
                }
                else
                {
                    Console.WriteLine("Not already appeared in the list.");
                    //add key:flower value:1
                    comparison[flower] = 1;
                }
            }
            ////Shows the dictionary keys/values
            //foreach (KeyValuePair<string, int> item in comparison)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            //}

            Console.ReadLine();
        }
    }
}
