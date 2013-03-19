namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LoanAccount : Account, IDepositable
    {
        private const int NoInterestForIndividuals = 3;
        private const int NoInterestForCompany = 2;

        public LoanAccount(Customer customer, double balance, double intersetRate)
            : base(customer, balance, intersetRate)
        {  
        }

        // Loan accounts can only deposit money, and his balance will grow;
        public void DepositMoney(double checkin)
        {
            if (checkin <= 0)
                throw new InvalidDepositException("You have to deposit more than 0");
            this.Balance += checkin;
        }

        public override void CalculateInterestAmount(uint months)
        {
            // Loan accounts have no interest for the first 3 months if are held by individuals;
            // and for the first 2 months if are held by company;
            double interest = 0;
            if(this.Customer == Customer.Individual)
            {
                double tempAmount = 0;
                if(months >= NoInterestForIndividuals)
                {
                    tempAmount += base.InterestRate * (months - NoInterestForIndividuals);
                }
                InterestAmount = tempAmount;
            }
            else if(this.Customer == Customer.Company)
            {
                double tempAmount = 0;
                if(months >= NoInterestForCompany)
                {
                    tempAmount += base.InterestRate * (months - NoInterestForCompany);
                }
                InterestAmount = tempAmount;
            }
        }
    }
}
