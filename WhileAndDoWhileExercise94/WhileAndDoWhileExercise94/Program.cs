using System;

namespace WhileAndDoWhileExercise94
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIME NUMBER CONSOLE APP INTRODUCTION
            Console.WriteLine("Welcome to the Prime Number Checker! Continue guessing numbers until you've guessed a prime number.");
            //WHILE LOOP BOOLEAN
            bool isPrime = false;

            while (isPrime == false)
            {
                //INITIALIZE VARIABLES AND FLAG
                int n, i, m = 0, flag = 0;

                //PROMPT USER TO INPUT NUMBER
                Console.Write("\n   Enter a Number to check Prime: ");

                //READ NUMBER FROM CONSOLE
                n = Convert.ToInt32(Console.ReadLine());

                //m IS USED TO CHECK IF n IS DIVISIBLE. DON'T NEED TO CHECK FOR i > n/2 BECAUSE THOSE ARE EITHER PRIME OR FACTORS OF NUMBERS <= n/2.
                //FOR EFFICIENCY, THE CONDITION DOES NOT NEED TO BE CHECKED TWICE.
                m = n / 2;

                //START THE LOOP AT i = 2, for all i less than m
                for (i = 2; i <= m; i++)
                {
                    //IF THE REMAINDER IS 0, THEN THE NUMBER IS DIVISIBLE BY ANOTHER NUMBER. 
                    //BY DEFINITION THE NUMBER IS NOT PRIME.
                    if (n % i == 0)
                    {
                        Console.Write("   Sorry, " + n + " is NOT a prime number.\n");
                        //ASSIGN FLAG = 1 TO CAPTURE THIS "NOT PRIME" RESULT
                        //WITH FLAG == 1, THE NEXT IF STATEMENT WILL NOT BE EXECUTED.
                        flag = 1;
                        break;
                    }
                }
                //IF THERE WERE NO "NOT PRIME" RESULTS DISCOVERED IN THE ABOVE IF STATEMENT,
                //THE NUMBER MUST BE PRIME.
                if (flag == 0)
                {
                    Console.WriteLine("   Yes! " + n + " is a prime number!\n");
                    //CHANGE ISPRIME TO TRUE TO EXIT WHILE LOOP.
                    isPrime = true;
                }
            
            }

            //TRIVIA CONSOLE APP INTRODUCTION
            Console.WriteLine("Now that you're warmed up. Let's get started with a trivia question.\n");
            Console.WriteLine("   What is the heaviest naturally occuring element found on Earth? :");

            //INITIATE FIRST ANSWER FROM USER
            string answer = Console.ReadLine().ToLower();

            //WHILE LOOP BOOLEAN
            bool isCorrect = answer == "uranium";
            
            //USE DO LOOP TO ENSURE THE WHILE LOOP WILL BE INITIATED IF THE USER GUESSES CORRECTLY THE FIRST TIME.
            do
            {
                //IF THE ANSWER IS INCORRECT, INFORM THE USER AND ALLOW THEM TO GUESS AGAIN
                if (answer != "uranium")
                {
                    Console.WriteLine("   Sorry, " + answer + " is incorrect.");
                    Console.WriteLine("Guess again.");
                    answer = Console.ReadLine().ToLower();
                }
                //IF THE ANSWER IS CORRECT, INFORM THE USER AND END LOOP BY CHANGING BOOLEAN TO TRUE
                else
                {
                    Console.WriteLine("   CORRECT! Uranium (U92) is the heaviest naturally occuring element found on Earth.");
                    isCorrect = true;
                }
            }
            while (isCorrect == false);
            Console.ReadLine();
            
        }
    }
}
