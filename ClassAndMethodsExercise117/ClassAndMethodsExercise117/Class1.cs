using System;


namespace ClassAndMethodsExercise117
{
    //1
    //Create a class
    class Class1
    {
        //create a void method that outputs an integer.
        public int divideByTwo(int integer1)
        {
            //have the method divide the data passed to it by 2.
            int quotient = integer1 / 2;
            return quotient;
        }

        //4
        //create a method with output parameters
        public void getx(out int x, out int m)
        {
            int y = 200;
            x = y;
            m = y / 2;
        }

        //5
        //overload a method
        public int divideByTwo(string string1)
        {
            int quotient = Convert.ToInt32(string1) / 2;
            return quotient;
        }

    }
}
