using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankSystem
{
    class Program
    {
        static void Main()
        {
            MortgageAccount mortgage = new MortgageAccount(Customer.Individual, 2000, 1.5);
            LoanAccount loan = new LoanAccount(Customer.Company, 1500, 2);
            DepositAccount deposit = new DepositAccount(Customer.Individual, 600, 3);
            deposit.CalculateInterestAmount(6);
            Console.WriteLine(deposit.InterestAmount);
            mortgage.DepositMoney(150);
            Console.WriteLine(mortgage.Balance);
            
            deposit.WithdrawMoney(1000);
            Console.WriteLine(deposit.Balance);
            // This will cause an exception, because we can't deposit 0 or less money;
            mortgage.DepositMoney(0);
        }
    }
}
