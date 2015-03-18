//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        //Input for phone number; The format is string so we check if all the element except the firts one (+) are different from numbers//
        //-------------------------------------------------------------------------------------------------------------------------------//
        string phoneNumber;
        
        while (true)
        {
            Console.Write("Phone number: ");
            phoneNumber = Console.ReadLine();
            bool isCorrectPhoneNumber = true;

            if (phoneNumber.Length == 0)
            {
                isCorrectPhoneNumber = false;
            }

            for (int i = 1; i < phoneNumber.Length; i++)
            {
                if (((int)phoneNumber[i] >= 48 && (int)phoneNumber[i] <= 57) || phoneNumber[i] == ' ')
                {
                    break;
                }

                isCorrectPhoneNumber = false;
            }

            if (isCorrectPhoneNumber == true)
            {
                break;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------//
        
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());

        //Input for manager phone number; The format is string so we check if all the element except the firts one (+) are different from numbers//
        //-------------------------------------------------------------------------------------------------------------------------------//
        string managerPhoneNumber;

        while (true)
        {
            Console.Write("Manager number: ");
            managerPhoneNumber = Console.ReadLine();
            bool isCorrectPhoneNumber = true;
            
            if (managerPhoneNumber.Length == 0)
            {
                isCorrectPhoneNumber = false;
            }

            for (int i = 1; i < managerPhoneNumber.Length; i++)
            {
                if (((int)managerPhoneNumber[i] >= 48 && (int)managerPhoneNumber[i] <= 57) || managerPhoneNumber[i] == ' ')
                {
                    break;
                }

                isCorrectPhoneNumber = false;
            }

            if (isCorrectPhoneNumber == true)
            {
                break;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------//
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", managerPhoneNumber);
        
        if (String.IsNullOrEmpty(faxNumber))
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", faxNumber);
        }

        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhoneNumber);
        Console.WriteLine("-----------------------------------------------------------------------------");
    }
}
