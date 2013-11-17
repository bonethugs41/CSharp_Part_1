//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.



using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Title = "NUmber comparison";

        Console.WriteLine("Input number A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Input number B:");
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);
        Console.WriteLine("The greater number is {0}.", max);

    }
}