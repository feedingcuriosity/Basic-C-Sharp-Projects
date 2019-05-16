using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise165
{
    //inherit from exception class
    class NegativeException : Exception
    {
        //constructor from exception
        public NegativeException() : base() { }

    }
}
