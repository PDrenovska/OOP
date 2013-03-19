namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public interface IWithdrawable
    {
        void WithdrawMoney(double checkout);
    }
}
