using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is also helpful for debugging
            try
            {
                Console.WriteLine("Pick a number:");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                //or 
                //console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex) //general exception = any kind of exception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); //this ensure that this line will occur regardless of catch
            }
            Console.ReadLine();
        }
    }
}
