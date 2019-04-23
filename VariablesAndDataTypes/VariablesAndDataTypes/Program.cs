using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program (comment shortcut = ctrl+k+c)
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine(); //ReadLine can only operate on a string
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42; //green line means that the variable hasn't been used yet.
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; //m for decimal

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f; //f for float

            short temperatureOnMars = -341;

            string myName = "kasi";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainginStatus = Convert.ToString(isRaining);

            Console.WriteLine(isRaining);
            Console.ReadLine();

        }
    }
}
