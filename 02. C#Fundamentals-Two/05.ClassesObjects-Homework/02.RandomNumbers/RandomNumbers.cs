﻿//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
    class RandomNumbers
    {
        static void Main()
        {
            Random currentGeneratedNumber = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Number \"{0}\" --> {1}", i, currentGeneratedNumber.Next(100, 201));
            }
        }
    }