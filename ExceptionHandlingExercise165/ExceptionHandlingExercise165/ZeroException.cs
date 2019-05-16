using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise165
{
    class ZeroException : Exception
    {
        //constructor from exception
        public ZeroException() : base() { }
    }
}
