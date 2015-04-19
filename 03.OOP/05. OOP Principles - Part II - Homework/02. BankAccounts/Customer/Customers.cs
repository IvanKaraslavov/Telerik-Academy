namespace BankAccounts.Customer
{
    using System;
    using System.Text;

    public abstract class Customers
    {
        private string name;

        public Customers(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a customer's name");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" \nCustomer's name: {0}", this.Name);
            return sb.ToString();
        }
    }
}
