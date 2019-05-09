using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExercise140
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Create a list of at least 10 employees (including first, last name, and id)
            //At least two employees should have the first name joe.
            //a - instantiate at least 10 employee objects and define properties
            Employee employee = new Employee();
            employee.firstName = "Joe";
            employee.lastName = "Williams";
            employee.iD = 1;

            Employee employee1 = new Employee();
            employee1.firstName = "Alicia";
            employee1.lastName = "Gardner";
            employee1.iD = 2;

            Employee employee2 = new Employee();
            employee2.firstName = "Makena";
            employee2.lastName = "Obrien";
            employee2.iD = 3;

            Employee employee3 = new Employee();
            employee3.firstName = "Joe";
            employee3.lastName = "Pace";
            employee3.iD = 4;

            Employee employee4 = new Employee();
            employee4.firstName = "Ronald";
            employee4.lastName = "Beltran";
            employee4.iD = 5;

            Employee employee5 = new Employee();
            employee5.firstName = "Mara";
            employee5.lastName = "Franklin";
            employee5.iD = 6;

            Employee employee6 = new Employee();
            employee6.firstName = "Isabelle";
            employee6.lastName = "Harrison";
            employee6.iD = 7;

            Employee employee7 = new Employee();
            employee7.firstName = "Antoine";
            employee7.lastName = "Morales";
            employee7.iD = 8;

            Employee employee8 = new Employee();
            employee8.firstName = "Jeramiah";
            employee8.lastName = "Donaldson";
            employee8.iD = 9;

            Employee employee9 = new Employee();
            employee9.firstName = "Essence";
            employee9.lastName = "Wang";
            employee9.iD = 10;

            Employee employee10 = new Employee();
            employee10.firstName = "Angel";
            employee10.lastName = "Moon";
            employee10.iD = 11;

            //b - add all 11 employee's to people list
            List<Person> people = new List<Person>();
            people.Add(employee);
            people.Add(employee1);
            people.Add(employee2);
            people.Add(employee3);
            people.Add(employee4);
            people.Add(employee5);
            people.Add(employee6);
            people.Add(employee7);
            people.Add(employee8);
            people.Add(employee9);
            people.Add(employee10);

            //c - print out list to ensure it was populated properly
            foreach (Person person in people)
            {
                Console.Write("\n{0}\n{1}\n{2}\n", person.firstName, person.lastName, person.iD); 
            }

            Console.ReadLine();

            //2
            //using a foreach loop, create a new list of all employees with the first name "Joe"
            Console.WriteLine("List of 'Joes' using a foreach loop:");
            List<Person> joeList = new List<Person>();
            foreach (Person person in people)
            {
                if (person.firstName == "Joe")
                {
                    joeList.Add(person);
                    //Write new list to console to check work
                    Console.WriteLine("\n{0}\n{1}\n{2}\n", person.firstName, person.lastName, person.iD);
                }
            }
            Console.ReadLine();


            //3
            //do the same thing as (2) using a lambda expression
            Console.WriteLine("List of 'Joes' using a lambda expresion:");
            List<Person> joeListLambda = people.Where(x => x.firstName == "Joe").ToList();
            //write new list to console to check work
            foreach (Person person in joeListLambda)
            {
                Console.WriteLine("\n{0}\n{1}\n{2}\n", person.firstName, person.lastName, person.iD);
            }
            Console.ReadLine();

            //4
            //using a lambda expression, make a list of all employees with an Id number greater than 5
            Console.WriteLine("List of all employees with an Id number greater than 5:");
            List<Person> idGreaterThan5 = people.Where(x => x.iD > 5).ToList();
            //write new list to console to check work
            foreach (Person person in idGreaterThan5)
            {
                Console.WriteLine("\n{0}\n{1}\n{2}\n", person.firstName, person.lastName, person.iD);
            }
            Console.ReadLine();

        }
    }
}
