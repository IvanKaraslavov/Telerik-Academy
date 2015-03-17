namespace BankAccounts.Accounts
{
    using System;
    using System.Threading.Tasks;
    using BankAccounts.Customer;

    public class LoanAccount : Account
    {
        public LoanAccount(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterestAmount(int months)
        {
            if ((Customer is Individual && months > 3) || (Customer is Company && months > 2))
            {
                return base.CalculateInterestAmount(months);
            }
            else
            {
                return 0;
            }
        }
    }
}
