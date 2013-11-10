//Write a program that safely compares floating-point numbers with precision of 0.000001.


using System;

class TrueFalse
{
    static void Main()
    {
        Console.Title = "compare numbers";
        Console.Write("input first number:");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("input second number:");
        float n2 = float.Parse(Console.ReadLine());
        bool compare = (n1 == n2);
        Console.WriteLine("Result:");
        if (n1 == n2)
        {
            Console.WriteLine("the numbers are equal");
        }
        else
        {
            Console.WriteLine("the numbers are not equal");
        }
    }
}
