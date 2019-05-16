using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise165
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //1
                //Ask the user for their age
                Console.WriteLine("Please enter your age:");
                //store in variable and format as integer
                int userAge = Convert.ToInt16(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                if (userAge == 0)
                {
                    throw new ZeroException();
                }
                //2
                //Display the year user born
                //use DateTime struct
                DateTime today = DateTime.Today;
                int thisYear = today.Year;

                int userBirthYear = thisYear - userAge;

                Console.WriteLine("\nYour birth year is:");
                Console.WriteLine(userBirthYear);
                Console.ReadLine();
            }
            //3
            //Exceptions must be handled using "try... catch."
            //4
            //Display appropriate error messages if user enters zero or negative numbers
            //catch exception for zero
            catch (NegativeException)
            {
                Console.WriteLine("You entered a negative number. Age must be greater than or equal to 1.");
                Console.ReadLine();
                return;
            }
            //catch exception for negative numbers, write comment that age can't be less than zero.
            catch (ZeroException)
            {
                Console.WriteLine("You entered 0. Age must be greater than or equal to 1.");
                Console.ReadLine();
                return;
            }
            //5
            //Display general message if exception caused by anything else
            //catch exception for everything else (e.g., strings that can't be converted to int)
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator");
                Console.ReadLine();
                return;
            }

        }
    }
}
