using System;
using System.Collections.Generic; //Used when we get into lists

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTS - more common than arrays
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);


            List<string> stringList = new List<string>();
            stringList.Add("Hello");

            Console.WriteLine(stringList[0]);

            Console.WriteLine(intList[0]);
            Console.ReadLine();


            //ARRAYS - use when you have a fixed quantity that you want grouped together that you know isn't going to change.
            //       - use when you have a very large quantity
            int[] numArray = new int[5]; //set an integer array called numArray. Still needs to be instantiated because an array is an object.
                                         //must also define the length of the array when instantiated.
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //once this length is set, it can't be undone. But you can change the values

            int[] numArray2 = { 5, 2, 10, 200, 5000 }; //Will automatically figure out you're initializing the array

            //change 5000 to 650
            numArray2[4] = 650;


            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray1[3]);
            Console.WriteLine(numArray2[4]);
            Console.ReadLine();

        }
    }
}
