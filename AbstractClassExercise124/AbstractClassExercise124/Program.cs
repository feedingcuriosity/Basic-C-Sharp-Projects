using System;

namespace AbstractClassExercise124
{
    class Program
    {
        static void Main(string[] args)
        {
            //5
            //instantiate an employee object with firstName "Sample" and LastName "Student"
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //call the SayName() method on the object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
