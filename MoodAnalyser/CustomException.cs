using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class CustomException : Exception
    {
        public ExceptionType type;

        
        public enum ExceptionType //enum data type
        {
            NULL_TYPE_EXCEPTION,
            EMPTY_TYPE_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND

        }

        public CustomException(ExceptionType type, string message) : base(message) // constructor
        {
            this.type = type;
        }
    }
}
