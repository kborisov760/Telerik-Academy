//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Stoyanov";
        string lastName = "Petrov";
        double accountBalance = 235589D;
        string bankName = "Eurobank";
        string IBAN = "BG8561R2359AA9I";
        uint firstCardNumber = 54555465;
        uint secondCardNumber = 45631567;
        uint thirdCardNumber = 31675236;
    }
}
