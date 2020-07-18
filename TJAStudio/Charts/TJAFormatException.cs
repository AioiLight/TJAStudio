using System;

namespace TJAStudio
{
    public class TJAFormatException : Exception
    {
        public TJAFormatException()
        {
        }

        public TJAFormatException(string message)
            : base(message)
        {
        }

        public TJAFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class InvalidTJAFormatException : TJAFormatException
    {
        public InvalidTJAFormatException()
            : base()
        {
        }

        public InvalidTJAFormatException(string message)
            : base(message)
        {
        }

        public InvalidTJAFormatException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class CommandWithoutSpaceException : TJAFormatException
    {
        public CommandWithoutSpaceException()
            : base()
        {
        }

        public CommandWithoutSpaceException(string message)
            : base(message)
        {
        }

        public CommandWithoutSpaceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}