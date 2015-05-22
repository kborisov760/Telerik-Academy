namespace BankAccounts.Classes
{
    public interface IAccount
    {
        void Deposit(decimal sum);
        void PrintAccount();
        decimal CalculateInterestRate(uint numberOfMonths);
    }
}
