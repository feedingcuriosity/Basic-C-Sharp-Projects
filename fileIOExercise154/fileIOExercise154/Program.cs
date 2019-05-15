using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIOExercise154
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Ask user for a number
            Console.WriteLine("Please provide a number:");
            //store the userNumber to variable of string datatype
            string userNumber = (Console.ReadLine() +"\n");
            //2
            //log that number to a text file
            //use streamwriter to append the log
            using (StreamWriter file = new StreamWriter(@"C:\users\kasan\numberLog.txt", true))
            {
                file.WriteLine(userNumber);
            }
            //3
            //print the text file back to the user
            Console.WriteLine(File.ReadAllText(@"C:\users\kasan\numberLog.txt"));
            Console.ReadLine();

        }
    }
}
