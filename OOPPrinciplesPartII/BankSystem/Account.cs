namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Account
    {
        protected Customer Customer;
        public double InterestAmount
        {
            get; protected set; 
        }
        protected uint MonthsPeriod;
        protected double InterestRate; // only for bulgarian : лихвен процент
        public double Balance;

        protected Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        // only for bulgarian : общата дължима лихва за броя месеци
        public abstract void CalculateInterestAmount(uint months);
    }
}
