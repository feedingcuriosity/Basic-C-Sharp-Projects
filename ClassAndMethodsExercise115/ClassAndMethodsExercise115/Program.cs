using System;


namespace ClassAndMethodsExercise115
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //instantiate the class
            Class1 s = new Class1();

            //3
            //ask the user to input at least one number, one at a time. 
            //first number is required. Second number is optional.
            Console.WriteLine("Please enter a whole number:");
            //obtain input and convert string to integer
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to provide a second number? If not, press enter. If so, enter second number here:");
            //Create temporary variable inputCheck to determine if a number was entered
            string inputCheck = Console.ReadLine();
            //Create if/else statement to perform different actions if a number was provided or not.
            if (string.IsNullOrEmpty(inputCheck))
            {
                //4
                //call the method passing in the only parameter entered and second parameter is default
                int sum = s.mathOperation(integer1: firstInput);
                Console.WriteLine(sum);
            }
            else
            {
                //convert the string input to integer
                int secondInput = Convert.ToInt32(inputCheck);
                //call the method passing in both parameters
                int sum = s.mathOperation(integer1: firstInput, integer2: secondInput);
                Console.WriteLine(sum);
            }
            
            Console.ReadLine();

        }
    }
}
