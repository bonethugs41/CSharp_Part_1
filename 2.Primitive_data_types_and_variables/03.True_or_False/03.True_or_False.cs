//Write a program that safely compares floating-point numbers with precision of 0.000001.


using System;

class TrueFalse
{
    static void Main()
    {
        Console.Title = "Compare Numbers";
        Console.Write("Input first number:");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        float n2 = float.Parse(Console.ReadLine());
        bool compare = (n1 == n2);
        if (n1 == n2)
        {
            Console.WriteLine("The numbers are equal");
        }
        else
        {
            Console.WriteLine("The numbers are not equal");
        }

    }
}
