namespace BankAccounts.Classes
{
    using System;
    public class LoanAccount : Credit
    {
        private const uint No_INTEREST_PERIOD_INDIVIDUALS = 3;
        private const uint No_INTEREST_PERIOD_COMPANY = 2;
        public LoanAccount(Customer customerData, AccountType accountType, decimal accountBalance, decimal interestRate, uint monthsRateApplied)
            : base(customerData, accountType, accountBalance, interestRate, monthsRateApplied) { }

        public override decimal CalculateInterestRate(uint numberOfMonths)
        {
            uint effectiveNumberOfMonths = numberOfMonths;
            if ((this.periodOfInterestRateApplied <= No_INTEREST_PERIOD_INDIVIDUALS) && (this.CustomerData.Type == CustomerType.Individual))
            {
                effectiveNumberOfMonths -= (No_INTEREST_PERIOD_INDIVIDUALS - this.periodOfInterestRateApplied);
            }
            else if ((this.periodOfInterestRateApplied <= No_INTEREST_PERIOD_COMPANY) && (this.CustomerData.Type == CustomerType.Company))
	        {
		        effectiveNumberOfMonths -= (No_INTEREST_PERIOD_COMPANY - this.periodOfInterestRateApplied);
	        }
            
            while (effectiveNumberOfMonths > 0)
            {
                this.accountBalance *= 1 + (this.InterestRate / 100);
                effectiveNumberOfMonths--;
            }
            this.periodOfInterestRateApplied += numberOfMonths;

            return accountBalance;

        }
    }
}
