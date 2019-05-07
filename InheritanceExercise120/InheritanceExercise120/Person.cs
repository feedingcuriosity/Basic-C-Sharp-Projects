using System;

namespace InheritanceExercise120
{
    //1
    //Create a class called "Person"
    public class Person
    {
        //create FirstName and LastName properties of type string
        public string FirstName;
        public string LastName;

        //2
        //create void method called SayName()
        public void SayName()
        {
            //write the person's full name in the format of: "Name: [full name]"
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }



    }
}
