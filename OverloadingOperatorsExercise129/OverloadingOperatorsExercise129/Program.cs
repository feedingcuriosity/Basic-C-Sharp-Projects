

namespace OverloadingOperatorsExercise129
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two employee objects for comparison
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.employeeId = 1;

            Employee employee2 = new Employee();
            employee2.firstName = "Second";
            employee2.lastName = "Student";
            employee2.employeeId = 1;

            //Use overloaded operator
            bool checkEqual = employee1 == employee2;

        }

    }
}
