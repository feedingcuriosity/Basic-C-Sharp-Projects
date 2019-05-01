using System;
using System.Collections.Generic; //List data type uses this class


namespace Iteration
{
    class Program
    {
        static void Main(string[] args) //passing in a string array as an argument to this Main function. You could pass in arguments from the command line.
        {
            //    //Create an array of testScores
            //    int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //    //Iterate over the array - using for loop
            //    //log to the console the scores that are a passing grade (>85)
            //    //create for loop with 3 conditions
            //    //1. starting value (i can be any letter)
            //    //2. how long are you doing this for loop? Until what is false?
            //    //3. what you want to do after each time through the for loop?
            //    for (int i = 0; i < testScores.Length; i++)
            //    {
            //        if (testScores[i] > 85)
            //        {
            //            Console.WriteLine("Passing test score: " + testScores[i]);
            //        }
            //    }
            //    Console.ReadLine();

            ////do the same thing with a string array
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            ////Print string array to the conosle
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            ////List iterations
            ///////////////////
            //List<int> testScores = new List<int>();
            ////Add test scores manually
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            ////Use foreach loop
            //    //score represents item in list testScores
            //foreach (int score in testScores)
            //{
            //    if (score >85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);

            //    }

            //}
            //Console.ReadLine();

            ////List iteration with string
            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            ////Add into empty list
            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score>85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();
        }
    }
}
