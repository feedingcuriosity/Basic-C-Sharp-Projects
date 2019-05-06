using System;

namespace ClassAndMethodsExercise114
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //instantiate the class
            Class1 q = new Class1();
            //call the one method, passing an integer, such as 12
            int quotient = q.mathOperation(integer1: 12);
            //display the result to the screen
            Console.WriteLine(quotient);

            //4
            //instantiate the class
            Class1 p = new Class1();
            //call the second method, passing in a decimal.
            int product = p.mathOperation(decimal1: 2.3m);
            //display the result to the screen
            Console.WriteLine(product);

            //6
            //instantiate the class
            Class1 d = new Class1();
            //call the third method, passing in a string that equates to an integer.
            int difference = d.mathOpeartion(string1: "1");
            //display the result to the screen
            Console.WriteLine(difference);

            Console.ReadLine();
        }
    }
}
