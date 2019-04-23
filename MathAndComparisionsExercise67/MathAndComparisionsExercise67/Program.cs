using System;


namespace MathAndComparisionsExercise67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymouse Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            decimal Person1_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            decimal Person1_HoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            decimal Person2_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            decimal Person2_HoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            decimal Person1_AnnualSalary = Person1_HourlyRate * Person1_HoursWorked * 52;
            Console.WriteLine(Person1_AnnualSalary);

            Console.WriteLine("Annual salary of Person 2:");
            decimal Person2_AnnualSalary = Person2_HourlyRate * Person2_HoursWorked * 52;
            Console.WriteLine(Person2_AnnualSalary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareSalaries = Convert.ToBoolean(Person1_AnnualSalary > Person2_AnnualSalary);
            Console.WriteLine(compareSalaries);

            Console.ReadLine();

        }
    }
}
