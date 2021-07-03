using System;

namespace CalendarEditor.Exceptions
{
    public class InvalidEndDateException : InvalidOperationException
    {
        public InvalidEndDateException()
        {
        }

        public InvalidEndDateException(string message) : base(message)
        {
        }
    }
}