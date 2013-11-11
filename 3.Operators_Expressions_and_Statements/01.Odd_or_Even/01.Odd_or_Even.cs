//Write an expression that checks if given integer is odd or even.



using System;

class OddEven
{
    static void Main()
    {
        Console.Title = "Odd or Even";
        Console.WriteLine("Type some nuber to check if odd or even");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("{0} is odd", a);
        }
        else
        {
            Console.WriteLine("{0} is even", a);
        }
    }
}