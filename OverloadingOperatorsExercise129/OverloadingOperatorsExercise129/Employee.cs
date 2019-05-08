using System;

namespace OverloadingOperatorsExercise129
{
    public class Employee : Person
    {
        //create Id property for comparison
        public int employeeId;

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        //1
        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        //syntax --> access specifier  className  operator Operator_symbol (parameters)
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.employeeId.Equals(employee2.employeeId))
            {
                Console.WriteLine("Error: these employees have the same ID.");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("No Error: these employees have diffrent employee IDs.");
                Console.ReadLine();
                return false;
            }
        }

        //Per microsoft documentation == must be accomanied by !=
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }



    }
}
