namespace BankAccounts.Accounts
{
    using System;
    using System.Text;
    using BankAccounts.Customer;
    using BankAccounts;

 public abstract class Account : IDeposible
    {
        private Customers customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            return months * this.InterestRate;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You can't deposit negative amount of money.");
            }

            this.Balance += amount;
        }

        public Customers Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a customer");
                }
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Customer's type: {0} \n", this.Customer.GetType().Name);
            sb.AppendFormat("Customer: {0} \n", this.Customer);
            sb.AppendFormat("Customer's balance: {0} \n", this.Balance);
            sb.AppendFormat("Customer's interest rate: {0} \n", this.InterestRate);
            return sb.ToString();
        }
    }
}
