using System;
using System.Collections.Generic;

namespace GenericsExercise131
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            //Instantiate an employee object with type string as its generic parameter
            Employee<string> employeeString = new Employee<string>();
            //Assign a list of strings as the property value of Things
            employeeString.things = new List<string>() { "thing1", "thing2", "thing3", "thing4" };

            //4
            //instantiate an employee object with type int as its generic parameter
            Employee<int> employeeInt = new Employee<int>();
            //Assign a list of integers as the property value of Things
            employeeInt.things = new List<int>() { 1, 2, 3, 4 };

            //5
            //Create a loop that prints all of the things to the console
            int i;
            Console.WriteLine("Things Strings: ");
            for (i = 0; i < employeeString.things.Count; i++)
            {
                Console.WriteLine(employeeString.things[i]);
            }
            Console.WriteLine("Things Ints: ");
            for (i = 0; i < employeeInt.things.Count; i++)
            {
                Console.WriteLine(employeeInt.things[i]);
            }
            Console.ReadLine();
        }
    }
}
