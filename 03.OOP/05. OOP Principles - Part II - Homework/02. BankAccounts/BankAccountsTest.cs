namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using BankAccounts.Accounts;
    using BankAccounts.Customer;

    public class BankAccountsTest
    {
        public static void Print(IEnumerable<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
        }
        static void Main()
        {
            var accounts = new Account[] {
            new DepositAccount(new Individual("Penka"), 330M, 20M),
            new MortgageAccount(new Individual("Niki"), 1000M, 30M),
            new LoanAccount(new Company("McCompany"), 5000M, 45M),
            new DepositAccount(new Company("AnotherCompany"), 600000M, 76M)
            };

            accounts[0].Deposit(300);
            accounts[1].Deposit(200);
            accounts[2].Deposit(500);
            accounts[3].Deposit(700);
            ((DepositAccount)accounts[3]).Draw(200);

            Print(accounts);

            var result = accounts[3].CalculateInterestAmount(12);
            Console.WriteLine("The interest amount of the second deposit account for 12 months: {0}", result);
        }
    }
}
