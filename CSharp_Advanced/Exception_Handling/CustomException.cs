using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    public class CustomException : Exception
    {
        public CustomException(string message, Exception innerException) : base(message,innerException)
        {

        }
    }
}
