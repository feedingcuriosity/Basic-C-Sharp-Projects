using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExercise129
{
    //change to struct to hold a copy of the entire object.
    public class Employee
    {
        //create properties
        public string firstName;
        public string lastName;
        //create constructor
        public Employee(string firstname, string lastname)
        {
            firstName = firstname;
            lastName = lastname;
        }
        //1
        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        //syntax --> access specifier  className  operator Operator_symbol (parameters)
        public static bool operator== (Employee employee, Employee employee1)
        {

            if (employee.firstName == employee1.firstName && employee.lastName == employee1.lastName)
            {
                Console.WriteLine("True; These employees are equal");
                return true;
            }
            else
                Console.WriteLine("False; These employees are not equal");
                return false;
        }

        //== must be accomanied by !=
        public static bool operator!= (Employee employee, Employee employee1)
        {
            if (employee.firstName != employee1.firstName | employee.lastName != employee1.lastName)
            {
                Console.WriteLine("True; These employees are not equal.");
                Console.ReadLine();
                return true;               
            }
            else
            {
                Console.WriteLine("False; these employees are equal.");
                Console.ReadLine();
                return false;
            }
        }

    }
}
