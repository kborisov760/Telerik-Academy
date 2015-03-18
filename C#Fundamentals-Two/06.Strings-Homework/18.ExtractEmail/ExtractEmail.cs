//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Linq;
using System.Net.Mail;
using System.Text;
class ExtractEmail
{
    static readonly char[] separators = new char[] { ' ', '\t', ',', '!', '?', ':', ';', '(', ')', '{', '}', '[', ']' };
    static readonly char[] trimmers = new char[] { '.', '-', '/', '\\' };

    private static string GetEMails(string[] input)
    {
        StringBuilder result = new StringBuilder();

        foreach (var email in input)
        {
            result.AppendLine(email.Trim(trimmers));
        }


        if (result.Length == 0)
            result.AppendLine("No emails found!");
        return result.ToString();
    }

    static bool EmailIsValid(string email)
    {
        try
        {
            MailAddress address = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    static void Main()
    {
        string sample = "Hi! My email @ yahoo is myemail@yahoo.com. I also have 101mailGO@mail_provider.co.uk! You can write me to my work-email too:work_mail@privider.at.my.work";
        string[] input = sample.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(x => EmailIsValid(x.Trim(trimmers))).ToArray();

        Console.WriteLine(Environment.NewLine + GetEMails(input));
    }

   
}