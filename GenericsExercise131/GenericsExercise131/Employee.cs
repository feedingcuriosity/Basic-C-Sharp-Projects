using System;
using System.Collections.Generic;



namespace GenericsExercise131
{
    //1
    //make the employee class take a generic type parameter
    public class Employee<T> : Person
    {
        //2
        //Add a property to the Employee class called "things" and have its data type be a generic list
        //matching the generic type of the class
        public List<T> things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }


    }
}
