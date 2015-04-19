namespace BankAccounts.Accounts
{
    using System;
    using System.Threading.Tasks;
    using BankAccounts.Customer;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override decimal CalculateInterestAmount(int months)
        {
            if (Customer is Company)
            {
                if (months > 12)
                {
                    return base.CalculateInterestAmount(months);
                }
                else
                {
                    return base.CalculateInterestAmount(months) / 2;
                }
            }
            else
            {
                if (months < 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestAmount(months);
                }
            }
        }
    }
}
