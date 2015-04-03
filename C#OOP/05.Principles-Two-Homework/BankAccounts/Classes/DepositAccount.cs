namespace BankAccounts.Classes
{
    using System;
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customerData, AccountType accountType, decimal accountBalance, decimal interestRate, uint numberOfMonths)
            : base(customerData, accountType, accountBalance, interestRate) { }

        public override void Deposit(decimal sum)
        {
            ChangeBalance(sum);
        }

        public void Withdraw(decimal ammountOfMoney)
        {
            if (ammountOfMoney < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot enter negative ammount of money!");
            }
            else if (ammountOfMoney > this.AccountBalance)
            {
                throw new ArgumentOutOfRangeException("Cannot withdraw more than you have!");
            }

            ChangeBalance(-ammountOfMoney);
        }

        //TODO: Implement InterestRate calculation method - COMPLEX
        public override decimal CalculateInterestRate(uint numberOfMonths)
        {
            if (this.AccountBalance < 1000)
            {
                throw new Exception("This account does not calculate Interest rate in these conditions.");
            }
            else
            {
                decimal changedAccountBalance = this.AccountBalance;
                changedAccountBalance *= 1 + (this.InterestRate * numberOfMonths) / 100;
                return changedAccountBalance;
            }
        }
    }
}
