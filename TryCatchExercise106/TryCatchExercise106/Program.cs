using System;
using System.Collections.Generic;


namespace TryCatchExercise106
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Create a list of integers
            List<int> numbers = new List<int>() { 10, 55, 23, 19, 48 };
            //Ask the user for a number to divide each number in the list by
            Console.WriteLine("Please enter a number. (Note: Each number in the list will be divided by your selection)");        
            //2
            //Put the loop in a try/catch block.
            try
            {
                //retrieve user's entry
                int numberSelection = Convert.ToInt32(Console.ReadLine());
                //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the resutls to the screen.
                for (int i = 0; i < numbers.Count; i++)
                {
                    int quotient = numbers[i] / numberSelection;
                    Console.WriteLine(numbers[i] + " dividied by " + numberSelection + " is " + quotient + ", when rounded to the nearest integer.");
                }
            }
            //catch an error due to incorrect format for numberSelection
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            //catch if the numberSelection is zero - can't divide by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zerio.");
            }
            //catch any other edgecase errors and display automatic error message.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Continue to readline even if catch occurs to ensure error message is displayed.
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Division of numbers was completed successfully with no errors.");
            Console.ReadLine();
        }
    }
}
