using System;

namespace ClassAndMethodsExercise114
{
    //1
    //Create a class
    class Class1
    {
        //create a method that will take in an integer
        public int mathOperation(int integer1)
        {
            //do a math operation
            int quotient = integer1 / 100;

            //return the answer as an integer
            return quotient;
        }


        //3
        //create a second method, with the same name, that will take in a decimal
        //note: this method can have the same name because a different integer type is passed into the method
        //This means the compiler will know which unique method to call
        public int mathOperation(decimal decimal1)
        {
            //do a different math operation
            int product = Decimal.ToInt32(decimal1 * 100.0m);

            //return the answer as an integer
            return product;

        }

        //5
        //create a third method, with the same name, that will take in a string
        public int mathOpeartion(string string1)
        {
            //convert it to an integer, if possible
            try
            {
                int stringConvert = Convert.ToInt32(string1);

                //do a different math operation
                int difference = stringConvert - 100;

                //return the answer as an integer
                return difference;
            }
            catch (Exception)
            {
                int error = 505;
                return error;
            }
 
        }


    }
}
