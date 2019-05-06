using System;

namespace ClassAndMethodsExercise113
{
    //1
    //Create a class
    class Class1
    {
        //create a void method that takes two integers as parameters.
        //note: method syntax = <Access Specifier> <Return Type> <Method Name>(Parameter List) {Method Body}
        public void voidMethod(int integer1, int integer2)
            {
            //have the method do a math operation on the first integer
            int sum = integer1 + 293874;
            Console.WriteLine("293874 plus {0} is {1}.", integer1, sum);
            Console.ReadLine();

            //display the second integer to the screen 
            Console.WriteLine("The second integer is: {0}", integer2);
            Console.ReadLine();
        }
               

    }
}
