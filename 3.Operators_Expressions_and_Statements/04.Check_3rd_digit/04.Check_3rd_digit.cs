//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Check if third digit is 7";
        Console.WriteLine("Input number:");
        int someNumber = int.Parse(Console.ReadLine());
        someNumber = someNumber / 100;
        Console.WriteLine(someNumber % 10 == 7);
    }
}
