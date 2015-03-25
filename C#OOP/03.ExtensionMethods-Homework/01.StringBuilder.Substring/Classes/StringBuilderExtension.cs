namespace ExtensionMethods.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static string Substring(this StringBuilder input, int index, int length)
        {
            string output = string.Empty;
            string inpToString = input.ToString();
            for (int i = index; i <= length; i++)
            {
                output += inpToString[i];
            }
            return output;
        }
    }
}
