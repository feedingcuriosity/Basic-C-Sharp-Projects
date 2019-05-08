using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExercise129
{
    //change to struct to hold a copy of the entire object.
    public struct Employee
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
        public static bool operator== (Employee employee1, Employee employee2)
        {
         
            bool check = employee2.Equals(employee1);
            if (check)
            {
                Console.WriteLine(check + "; These employees are the same.");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine(check + "; These employees are not the same.");
                Console.ReadLine();
                return false;
            }
        }

        //== must be accomanied by !=
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool check = employee2.Equals(employee1);
            if (check)
            {
                Console.WriteLine((!(check)) + "; These employees are the same.");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.WriteLine((!(check)) + "; These employees are not the same.");
                Console.ReadLine();
                return true;
            }
        }

    }
}
