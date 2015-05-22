namespace BankAccounts.Classes
{
    using System;
    public class MortgageAccount : Credit
    {
        private const uint NO_INTEREST_PERIOD_INDIVIDUALS = 6;
        private const uint HALF_INTEREST_PERIOD_COMPANY = 12;
        public MortgageAccount(Customer customerData, AccountType accountType, decimal accountBalance, decimal interestRate, uint numberOfMonths)
            : base(customerData, accountType, accountBalance, interestRate, numberOfMonths) { }

        public override decimal CalculateInterestRate(uint numberOfMonths)
        {
            uint effectiveNumberOfMonths = numberOfMonths;
            if ((this.periodOfInterestRateApplied <= NO_INTEREST_PERIOD_INDIVIDUALS) && (this.CustomerData.Type == CustomerType.Individual))
            {
                effectiveNumberOfMonths -= (NO_INTEREST_PERIOD_INDIVIDUALS - this.periodOfInterestRateApplied);
            }
            else if ((this.periodOfInterestRateApplied <= HALF_INTEREST_PERIOD_COMPANY) && (this.CustomerData.Type == CustomerType.Company))
            {
                effectiveNumberOfMonths -= (HALF_INTEREST_PERIOD_COMPANY - this.periodOfInterestRateApplied);
            }

            while (effectiveNumberOfMonths > 0)
            {
                if (this.CustomerData.Type == CustomerType.Individual)
                {
                    this.accountBalance *= 1 + (this.InterestRate / 100);
                    effectiveNumberOfMonths--;
                }
                else if (this.CustomerData.Type == CustomerType.Company)
                {
                    if (effectiveNumberOfMonths <= HALF_INTEREST_PERIOD_COMPANY)
                    {
                        this.accountBalance *= (1 + (this.InterestRate / 100)) / 2;
                        effectiveNumberOfMonths--;
                    }
                    else
                    {
                        this.accountBalance *= 1 + (this.InterestRate / 100);
                        effectiveNumberOfMonths--;
                    }
                }
            }

            this.periodOfInterestRateApplied += numberOfMonths;
            return accountBalance;
        }
    }
}
