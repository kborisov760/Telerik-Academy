//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Welcome to Employee database!");
        Console.Write("Employee first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Employee last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Employee age: ");
        ushort age = ushort.Parse(Console.ReadLine());
        Console.Write("Employee ID (10 characters): ");
        ulong idNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Employee unique number (15 characters): ");
        ulong uniqueNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("..............................");
        Console.WriteLine("The employee {0} {1} is {2} years old, has an ID number {3} and unique number {4}.", firstName, lastName, age, idNumber, uniqueNumber);
        Console.WriteLine("..............................");
    }
}
