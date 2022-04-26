// Created by: Marshall Demars
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program finds whether the number is positive or negative
        int number;

        // input
        Console.WriteLine("This program lets the user pick a number");
        Console.WriteLine("");
        Console.WriteLine("The program will then calculate whether it's positive or negative");
        Console.WriteLine("");
        Console.Write("Input any positive or negative number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (number >= 0)
        {
            Console.WriteLine("this number is positive");
        } else {
            Console.WriteLine("this number is negative");
        }

        Console.WriteLine("\nDone.");
    }
}