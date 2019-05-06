namespace ClassAndMethodsExercise113
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //in the main() method, instantiate the class
            //note: instantiating class syntax = <class name> <local class name of choice> = new <class name>();
            Class1 s = new Class1();

            //3
            //call the method in the class, passing two numbers
            //note: calling methods syntax = <local variable name of choice> = <local class name>.<method name>(parameter1 , parameter2);
            //note 2: but in this case, we are not returning a value in the method because it's void
            //therefore, it is not assinged a variable for storage.
            s.voidMethod(20, 30);

            //call the method in the class, specifying the parameters by name
            s.voidMethod(integer1: 50, integer2: 100);
        }
    }
}
