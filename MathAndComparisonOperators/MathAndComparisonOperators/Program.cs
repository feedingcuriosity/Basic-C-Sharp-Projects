using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADDITION
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //SUBTRACTION
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference);
            //Console.ReadLine();

            //MULTIPLICATION
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //DIVISION
            //double quotient = 100.0 / 17.0; //must have decimal here in order for it to give double dec.
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //MODULOUS OPERATOR - remainder = odd, no remainder = even
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //COMPARISON OPERATORS
            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature > roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //BUSINESS LOGIC EXAMPLE, temp must be >= 70
            //bool isWarm = currentTemperature >= roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //EQUAL
            //bool isWarm = currentTemperature == roomTemperature;

            //NOT EQUAL
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();


        }
    }
}
