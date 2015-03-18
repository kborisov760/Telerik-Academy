//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
class CorrectBracketsCheck
{
    static void Main()
    {
        Console.Write("Enter expression to check: ");
        string expression = Console.ReadLine();
        bool isCorrect = true;

        if (expression.IndexOf(')') < expression.IndexOf('('))
        {
            isCorrect = false;
        }

        Console.WriteLine("The expression is correct? --> {0}", isCorrect);
    }
}
