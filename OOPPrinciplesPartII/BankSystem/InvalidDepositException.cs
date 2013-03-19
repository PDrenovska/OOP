namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class InvalidDepositException : Exception
    {
        public InvalidDepositException(string msg)
            :base(msg)
        {
        }
    }
}
