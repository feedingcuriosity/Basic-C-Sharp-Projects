using System;

namespace BranchingExercise92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt16(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packageHeight = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt16(Console.ReadLine());
                int sumOfDimensions = packageWidth + packageHeight + packageLength;

                if (sumOfDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double quote = sumOfDimensions * packageWeight / 100.0;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                }
            }
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            
        }
    }
}
