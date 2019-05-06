using System;


namespace ClassAndMethodsExercise117
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //instantiate the class
            Class1 q = new Class1();

            //3
            //have the user enter a number.
            Console.WriteLine("Please enter a whole number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //call the method on that number
            int quotient = q.divideByTwo(userInput);
            //display the output to the screen (it should be the entered number, divided by two)
            Console.WriteLine(quotient);
            Console.ReadLine();

            //calling the method with output parameters
            Class1 output = new Class1();
            int z;
            int t;
            output.getx(out z, out t);
            Console.WriteLine("The output value of parameter 1 and 2 from the getx class1 method are: {0}" +" and: {1}", z,t);
            Console.ReadLine();

            //calling the overload method that takes string input and converts it in the class method instead
            Class1 overload = new Class1();
            Console.WriteLine("Please enter a whole number:");
            string userInputString = Console.ReadLine();
            int quotientOverload = overload.divideByTwo(string1: userInputString);
            Console.WriteLine(quotientOverload);
            Console.ReadLine();

            //calling the staticClass static members
            Console.WriteLine("The state birds for Washington and Oregon are {0} and {1}, respectively.", staticClass.stateBirdWA, staticClass.stateBirdOR);
            Console.ReadLine();

        }
    }
}
