using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Exceptions
{
    public class UnAuthenticatedException : Exception
    {
        public UnAuthenticatedException(string message) : base(message)
        {

        }
    }
}
