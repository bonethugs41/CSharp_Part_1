//Write a program that reads 3 integer numbers from the console and prints their sum.


using System;

class Summary
{
    static void Main()
    {
        Console.Title = "Summary";
        Console.WriteLine("Please enter three random numbers" + "\nFirst number:");
        int int1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Second number:");
        int int2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Third number:");
        int int3 = int.Parse(Console.ReadLine());
        int sum;
        sum = int1 + int2 + int3;
        Console.WriteLine("Sum = {0} ", sum);
    }
}