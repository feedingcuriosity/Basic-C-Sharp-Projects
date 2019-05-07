using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExercise124
{
    //1
    //create abstract class called person
    public abstract class Person
    {
        //add two properties: string firstName and string lastName
        public string firstName;
        public string lastName;

        //2
        //create method SayName()
        public abstract void SayName();
        
    }
}
