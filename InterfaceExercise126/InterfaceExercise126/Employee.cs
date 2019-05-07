using System;


namespace InterfaceExercise126
{

    //2
    //have the employee class from the previous drill inherit that interface
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        //implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("Are you sure you would like to quit? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Environment.Exit(0);
            }            
        }

        



    }
}
