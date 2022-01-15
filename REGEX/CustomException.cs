using System;
using System.Collections.Generic;
using System.Text;

namespace REGEX
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            INVALID_MESSAGE, EMPTY_MESSAGE, NULL_MESSAGE
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
