using System;


namespace ClassAndMethodsExercise111
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            // ask the user what number thye want to do the math operations on
            Console.WriteLine("please enter a number you would like to do math operations on:");
            // get users number
            int userInput = Convert.ToInt32(Console.ReadLine());
            //Instantiate object Class1 and assign to variable "m"
            Class1 m = new Class1();
            // call each method and pass the user input to the method
            //method 1 - Multiply
            Console.WriteLine("First, we will multiply your number by 10:");
            int multiplyResult = m.Multiply(userInput);
            Console.WriteLine("Your number multiplied by 10 is "
                + multiplyResult);
            Console.ReadLine();
            //method 2 - Divide
            Console.WriteLine("Next, we will divide your number by 2:");
            int divideResult = m.Divide(userInput);
            Console.WriteLine("Your number divided by 2 is "
                + divideResult);
            Console.ReadLine();
            //method 3 - Subtract
            Console.WriteLine("Now, we will subtract 1 from your number:");
            int subtractResult = m.Subtract(userInput);
            Console.WriteLine("Your number minus 1 is "
                + subtractResult);
            Console.ReadLine();
            //display the returned integer to the screen
        }
    }
}
