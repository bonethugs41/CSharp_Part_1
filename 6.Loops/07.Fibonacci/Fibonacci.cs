//Write a program that reads a number N and calculates the sum of the first N members
//of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Title = "Sum of the first n members of Fibonacci sequence";
        int n;
        while (true)
        {
            Console.Write("Input n:");
            string check = Console.ReadLine();
            bool nCheck = int.TryParse(check, out n);
            if (nCheck == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number, try again.");
            }
        }
        BigInteger fib1 = 0;
        BigInteger fib2 = 1;
        BigInteger fib3 = 0;
        BigInteger sum = 1;
        Console.WriteLine("0 - {0}", fib1);
        Console.WriteLine("1 - {0}", fib2);
        for (int i = 0; i < n-1; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
            Console.WriteLine("{0} - {1}", (i + 2), fib3);
            sum = sum + fib3;
        }
        Console.WriteLine("The Sum is: {0}", sum);
    }
}