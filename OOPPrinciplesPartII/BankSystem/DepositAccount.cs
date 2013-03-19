namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {  
        }

        // If the customer deposits money, his balance will grow;
        public void DepositMoney(double checkin)
        {
            if (checkin <= 0)
                throw new InvalidDepositException("You have to deposit more than 0");
            this.Balance += checkin;
        }

        // If the customer withdraws money, his balance will drop away;
        public void WithdrawMoney(double checkout)
        {
            this.Balance -= checkout;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000;
        public override void CalculateInterestAmount(uint months)
        {
            if(this.Balance <= 0 || this.Balance > 1000)
                InterestAmount = base.InterestRate * months;
            else
            {
                InterestAmount = 0;
            }
        }
    }
}
