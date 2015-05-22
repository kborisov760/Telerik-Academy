namespace BankAccounts.Classes
{
    using System;
    public enum AccountType { Deposit, Loan, Mortgage }
    public abstract class Account : IAccount
    {
        protected decimal accountBalance;
        public Account(Customer customerData, AccountType accountType, decimal initialBalance, decimal interestRate)
        {
            this.CustomerData = customerData;
            this.AccountType = accountType;
            this.accountBalance = initialBalance;
            this.InterestRate = interestRate;
        }

        public Customer CustomerData { get; set; }
        public AccountType AccountType { get; set; }
        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Account balance cannot be negative!");
                }

                this.accountBalance = value;
            }
        }
        public decimal InterestRate { get; set; }

        public abstract void Deposit(decimal sum);

        public void PrintAccount()
        {
            //TODO: Implement method to print customer account
        }

        public abstract decimal CalculateInterestRate(uint numberOfMonths);

        protected void ChangeBalance(decimal sum)
        {
            this.accountBalance += sum;
        }

    }
}
