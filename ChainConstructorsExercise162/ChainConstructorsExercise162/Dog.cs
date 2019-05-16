using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstructorsExercise162
{
    class Dog
    {
        //3
        //chain two constructors together
        //constructor with 3 parameters
        public Dog(int age, string color, string name) : this(age, color, "unknown", name)
        {
        }

        //constructor with 4 parameters
        public Dog(int age, string color, string breed, string name)
        {   
            Age = age;
            Color = color;
            Breed = breed;
            Name = name;
        }

        //properties
        public int Age { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
    }
}
