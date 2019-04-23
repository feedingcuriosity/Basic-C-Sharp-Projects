using System;


namespace BooleanLogicExercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer True or False.");
            bool duiStatus = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt16(Console.ReadLine());

            bool qualified = age > 15 && duiStatus == false && speedingTickets <=3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
