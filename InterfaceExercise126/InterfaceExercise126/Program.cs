using System;


namespace InterfaceExercise126
{
    class Program 
    {
        static void Main(string[] args)
        {
            Person employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            //3
            //use polymorphism to create an object of type IQuittable
            IQuittable quit = new Employee();
            //call the Quit() method on it
            quit.Quit();
            Console.ReadLine();

        }
    }
}
