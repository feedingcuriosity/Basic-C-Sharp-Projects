using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsExercise111
{
    //Create a class
    class Class1
    {
        //create 3 methods
        //each of which will take on integer parameter in and retrun and integer
        //the methods do a math operation on the received parameter

        public int Multiply(int userInput)
        {
            int result;

            result = userInput * 10;
            return result;
        }
        public int Divide(int userInput)
        {
            int result;

            result = userInput / 2;
            return result;
        }
        public int Subtract(int userInput)
        {
            int result;

            result = userInput -1 ;
            return result;
        }
    }
}
