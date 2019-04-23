using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorsExercise66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MULTIPLICATION - Please pick a number between 0 and 10,000,000.");
            Int32 num1 = Int32.Parse(Console.ReadLine());
            Int32 product1 = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product1);

            Console.WriteLine("ADDITION - Please pick another number between 0 and 10,000,000.");
            Int32 num2 = Convert.ToInt32(Console.ReadLine());
            Int32 addition1 = num2 + 25;
            Console.WriteLine("Your number plus 25 is: " + addition1);


            Console.WriteLine("DIVISION - Please pick another number between 0 and 10,000,000.");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double division1 = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + division1);


            Console.WriteLine("COMPARISION - Please pick another number between 0 and 10,000,000.");
            Int32 num4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50 = num4 > 50;
            Console.WriteLine(greaterThan50);


            Console.WriteLine("MODULOUS - Please pick another number between 0 and 10,000,000.");
            Int32 num5 = Convert.ToInt32(Console.ReadLine());
            Int32 modulous1 = num5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + modulous1);
            Console.ReadLine();
        }
    }
}
