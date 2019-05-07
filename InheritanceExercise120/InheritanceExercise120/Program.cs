using System;

namespace InheritanceExercise120
{
    class Program
    {
        static void Main(string[] args)
        {
            //4
            //instantiate and initialize parameters of an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //5
            //call the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
