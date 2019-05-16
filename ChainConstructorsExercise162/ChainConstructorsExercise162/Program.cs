using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstructorsExercise162
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //create a const variable
            const string location = "Seattle";
            Console.WriteLine("Welcome to the {0} Dog Shelter. Please press enter to report your lost pet.", location);
            Console.ReadLine();

            //Ask for user input for Dog properties
            Console.WriteLine("Please enter your dog's name:");
            //2
            //Create a variable using the keyword var
            var name = Console.ReadLine();
            Console.WriteLine("Please enter your dog's age:");
            var age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter your dog's color:");
            var color = Console.ReadLine();

            //Check if breed is known to identify the constructor to utilize
            Console.WriteLine("Do you know your dog's breed?: (y/n)");
            var breedKnown = Console.ReadLine();
            if (breedKnown == "y")
            {
                Console.WriteLine("Please enter your dog's breed:");
                var breed = Console.ReadLine();
                //Instantiate/construct dog class with user inputs using 4 input constructor 
                Dog dog = new Dog(age, color, breed, name);
                Console.WriteLine("/nWe have received the following inforamtion: \nAge: {0}\nColor: {1}\nBreed: {2}\nName: {3}\n", Convert.ToString(dog.Age), dog.Color, dog.Breed, dog.Name);
            }
            else
            {
                //Instantiate/construct dog class with user inputs using 3 input chain constructor 
                Dog dog1 = new Dog(age, color, name);
                Console.WriteLine("Here is the information we have received: \nAge: {0}\nColor: {1}\nBreed: {2}\nName: {3}\n", Convert.ToString(dog1.Age), dog1.Color, dog1.Breed, dog1.Name);

            }
            Console.WriteLine("Thank you for the notification. We will check our records and get back to you. Best of luck finding your family.");
            Console.ReadLine();
        


        }
    }
}
