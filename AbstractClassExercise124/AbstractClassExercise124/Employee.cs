using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise124
{
    //3
    //create another class called Employee and it inherits from Person call (an employee is a person)
    public class Employee : Person
    {
        //4
        //Implement the SayName() method inside the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }


    }
}
