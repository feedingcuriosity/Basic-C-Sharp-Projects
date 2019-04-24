using System;
using System.Collections.Generic;

namespace ArraysAndListsExercise100
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATE STRING ARRAY
            string[] myStringArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" };
            //ASK USER TO SELECT AN INDEX OF THE ARRAY
            Console.WriteLine("Select a number between 0 and 5 to display a color: ");
            //STORE THE USERS SELECTION IN STRINGINDEX
            int stringIndex = Convert.ToInt16(Console.ReadLine());

            //USE IF STATEMENT TO MAKE SURE USER SELECTED NUMBER BETWEEN 0 AND 5
            if (stringIndex < myStringArray.Length)
            //CALL AND DISPLAY THE SELECTED COLOR FROM MYSTRINGARRAY
            {
                Console.WriteLine(myStringArray[stringIndex]);
            }
            else
            //PROVIDE ERROR MESSAGE
            {
                Console.WriteLine("I'm sorry. The number must be between 0 and " + (myStringArray.Length-1));
            }


            //CREATE INTEGER ARRAY
            int[] myIntArray = { 39, 90, 25, 1889, 198273, 28 };
            //ASK USER TO SELECT AN INDEX OF THE ARRAY
            Console.WriteLine("\nSelect a number between 0 and 5 to display a number: ");
            //STORE THE USERS SELECTION IN THE INTINDEX
            int intIndex = Convert.ToInt16(Console.ReadLine());

            //USE IF STATEMENT TO MAKE SURE USER SELECTED NUMBER BETWEEN 0 AND 5
            if (intIndex < myIntArray.Length)
            {
                //CALL AND DISPLAY THE SELECTED NUMBER FROM MYINTARRAY
                Console.WriteLine(myIntArray[intIndex]);
            }
            else
            //PROVIDE ERROR MESSAGE
            {
                Console.WriteLine("I'm sorry. The number must be between 0 and " + (myIntArray.Length-1));
            }
            

            //CREAT STRING LIST
            List<string> stringList = new List<string>();
            //ADD ITEMS TO LIST
            stringList.Add("Emilie du Chatelet");
            stringList.Add("Caroline Herschel");
            stringList.Add("Mary Anning");
            stringList.Add("Maria Mitchell");
            stringList.Add("Mary Somerville");
            stringList.Add("Lise Meitner");
            //ASK USER TO SELECT AN INDEX OF THE LIST
            Console.WriteLine("\nSelect a number between 0 and 5 to display an historic female scientist: ");
            //STORE THE USERS SELECTION IN THE INTINDEX
            int listIndex = Convert.ToInt16(Console.ReadLine());


            //USE IF STATEMENT TO MAKE SURE USER SELECTED NUMBER BETWEEN 0 AND 5
            if (listIndex < stringList.Count)
            {
                //CALL AND DISPLAY THE SELECTED NUMBER FROM stringList
                Console.WriteLine(stringList[listIndex]);
            }
            else
            //PROVIDE ERROR MESSAGE
            {
                Console.WriteLine("I'm sorry. The number must be between 0 and " + (stringList.Count - 1));
            }
            Console.ReadLine();
        }
    }
}
