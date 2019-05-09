using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExercise129
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two employee objects for comparison
            Employee employee = new Employee("Sample", "Student");
            Console.WriteLine("employee: \nFirst Name = {0} Last Name = {1}", employee.firstName, employee.lastName);

            Employee employee1 = new Employee ("new", "Student");
            Console.WriteLine("employee1: \nFirst Name = {0} Last Name = {1}\n", employee1.firstName, employee1.lastName);

            //Use overloaded operator
            Console.WriteLine("Are the two employees equal?");
            bool checkEqual = employee == employee1;
            Console.WriteLine("Are the two employees not equal?");
            bool checkNotEqual = employee != employee1;
        }

    }
}
