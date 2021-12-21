using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Exceptions
{
    public class InternalServiceErrorException : Exception
    {
        public InternalServiceErrorException(string message) : base(message)
        {

        }
    }
}
