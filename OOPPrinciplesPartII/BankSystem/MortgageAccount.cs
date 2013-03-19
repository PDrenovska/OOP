namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MortgageAccount : Account, IDepositable
    {
        private const int NoInterestForIndividuals = 6;
        private const int HalfInterestForCompany = 12;
        public MortgageAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {  
        }

        // Mortgage accounts can only deposit money;
        public void DepositMoney(double checkin)
        {
            if(checkin <= 0)
                throw new InvalidDepositException("You have to deposit more than 0");
            this.Balance += checkin;
        }

        // Mortgage accounts have 1/2 interest for the first 12 months for companies 
        // and no interest for the first 6 months for individuals;
        public override void CalculateInterestAmount(uint months)
        {
            if(Customer == Customer.Individual)
            {
                double tempAmount = 0;
                if (months >= NoInterestForIndividuals)
                {
                    tempAmount += (base.InterestRate * (months - NoInterestForIndividuals));
                }
                InterestAmount = tempAmount;
            }
            else if(Customer == Customer.Company)
            {
                double tempAmount = 0;
                if(months >= HalfInterestForCompany)
                {
                    tempAmount += (base.InterestRate * (months - HalfInterestForCompany));
                    tempAmount += (base.InterestRate*HalfInterestForCompany)/2;
                }
                else
                {
                    tempAmount += (base.InterestRate * months) / 2;
                }
                InterestAmount = tempAmount;
            }
            
        }
    }
}
