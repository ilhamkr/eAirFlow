using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Exceptions
{
    public class UserException : Exception
    {
        public int StatusCode { get; }

        public UserException(string message, int statusCode = 400) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
