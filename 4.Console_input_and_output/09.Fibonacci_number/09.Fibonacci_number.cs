//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …


using System;

class Fibonacci
{
    static void Main()
    {
        Console.Title = "Fibonacci number";
        Console.WriteLine("Press any key to view the Fibonacci sequence!");
        Console.ReadKey();
        long fib1 = 0;
        long fib2 = 1;
        long fib3 = 0;
        Console.WriteLine("0 - {0}", fib1);
        Console.WriteLine("1 - {0}", fib2);
        for (int i = 1; i < 100; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
            Console.WriteLine(i+1 + " - " + fib3);
        }
    }
}