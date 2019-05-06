
namespace ClassAndMethodsExercise115
{
    //1
    //add a class
    class Class1
    {
        //create a method that takes two integers as parameters. Make one of them optional
        //by setting second integer equal to a default value it becomes optional
        public int mathOperation(int integer1, int integer2 = 10)
        {
            //have the method do a math operation
            int sum = integer1 + integer2;
            //return an integer result
            return sum;
        }

    }
}
