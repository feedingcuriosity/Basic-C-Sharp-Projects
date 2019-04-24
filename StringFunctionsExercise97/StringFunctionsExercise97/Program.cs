using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsExercise97
{
    class Program
    {
        static void Main(string[] args)
        {
            //TOP 3 HEADLINES ON GOOGLE NEWS

            string headline1 = "Divided on Impeachment, Democrats Wrestle With Duty and Politics.";
            string headline2 = @"Mulvaney: ""I don't recall"" telling staffers not to mention election security to Trump.";
            string headline3 = "Philippines' Duterte Talks Trash (Literally) To Canada, Threatening War Over Garbage.";

            //CONCATENATE THREE STRINGS
            string top3Headlines = "The top 3 headlines on Google News are: \n" + headline1 +" \n"+ headline2 + " \n" + headline3;

            //CONVERT STRING TO UPPERCASE
            string upper = headline1.ToUpper();

            //CREATE A STRINGBUILDER AND BUILD A PARAGRAPH OF TEXT, ONE SENTENCE AT A TIME.
            StringBuilder sb = new StringBuilder();
            sb.Append("As Speaker Nancy Pelosi urges caution on impeachment, rank-and-file House Democrats are agonizing over the prospect of trying to oust President Trump, caught between their sense of historic responsibilities and political considerations in the wake of the special counsel’s damning portrait of abuses.");
            sb.Append("The Democrats — including more than 50 freshmen — are mindful that impeachment poses political risks that could endanger the seats of moderates and their majority, as well as strengthen Mr. Trump’s hand. ");
            sb.Append("They ran on kitchen-table issues dear to their constituents and do not want to be consumed in a partisan morass that might unite Republican voters in opposition.");
            sb.Append("But some prominent members of the 55-member strong Congressional Black Caucus and a newly empowered progressive caucus are pressing for action — three Democrats have filed articles of impeachment against Mr. Trump and dozens of others have signaled a willingness to consider that path.");

            Console.WriteLine(top3Headlines);
            Console.WriteLine(upper);
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
