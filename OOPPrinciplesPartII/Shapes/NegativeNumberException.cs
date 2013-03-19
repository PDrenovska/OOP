namespace Shapes
{
    using System;

    // When creating our own exceptions, it is good coding practice to end the class name of the user-defined exception with the word "Exception.";
    // Any custom exception we create needs to derive from the System.Exception class:
    public class NegativeNumberException : Exception
    {
        #region constructors
        // It is also good practice to implement the three recommended common constructors:
        public NegativeNumberException()
        {
        }

        // Public constructor with one parameter, that has default value;
        public NegativeNumberException(string msg = "You have entered non-positive number!")
            : base(msg)
        {
        }

        public NegativeNumberException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
        #endregion
    }
}
