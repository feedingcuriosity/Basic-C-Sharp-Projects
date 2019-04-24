using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", " + name +". \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = "C:\\Users\\Jesse";
            //string fileName2 = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //bool trueOrFalse2 = name.EndsWith("s"); //really helpful when parsing files

            //int length = name.Length;

            //string nameUpper = name.ToUpper();
            //string nameLower = name.ToLower();

            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(fileName2);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(trueOrFalse2);
            //Console.WriteLine(length);
            //Console.WriteLine(nameUpper);
            //Console.WriteLine(nameLower);
            //Console.ReadLine();

            //NOTE - STRINGS ARE IMMUTABLE - IT CAN'T BE CHANGED. A NEW STRING IS CREATED. THIS IS FINE FOR SMALL PROGRAMS.
            //SOLUTION = STRINGBUILDER

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
