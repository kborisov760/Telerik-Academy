﻿//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c; //temp value used for exchange
        Console.WriteLine("Values before exchange: a = {0} ; b = {1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Values after exchange: a = {0} ; b = {1}", a, b);
    }
}
