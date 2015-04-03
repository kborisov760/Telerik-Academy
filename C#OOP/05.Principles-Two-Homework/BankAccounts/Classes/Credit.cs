namespace BankAccounts.Classes
{
    public abstract class Credit : Account
    {
        /// <summary>
        /// field used to check what is the period for the whole IneterestRate applied to the account balance
        /// </summary>
        protected uint periodOfInterestRateApplied;
        public Credit(Customer customerData, AccountType accountType, decimal accountBalance, decimal interestRate, uint numberOfMonths)
            : base(customerData, accountType, accountBalance, interestRate) 
        {
            this.periodOfInterestRateApplied = numberOfMonths;
        }

        public override void Deposit(decimal sum)
        {
            ChangeBalance(-sum);
        }

    }
}
