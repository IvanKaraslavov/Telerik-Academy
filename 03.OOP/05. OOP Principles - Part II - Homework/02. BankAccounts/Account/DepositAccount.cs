namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customer;
    using BankAccounts;

    public class DepositAccount : Account, IDeposible, IDrawable
    {
        public DepositAccount( Customers customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public void Draw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("You can't draw more than the balance of the account.");
            }

            this.Balance -= amount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (this.Balance < 1000)
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
