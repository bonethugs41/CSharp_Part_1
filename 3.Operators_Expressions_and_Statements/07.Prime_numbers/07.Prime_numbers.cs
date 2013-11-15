//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.


using System;



class PrimeNumbers
{
    static void Main()

        // Check Sieve of Eratosthenes in Wikipedia.
    {
        Console.Title = "Prime or not?";
        Console.WriteLine("Input some number between 0 and 100:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int divisor = 2; divisor < number; divisor++)
        {
            if (number != divisor && number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("{0} is prime.", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime.", number);
        }
    }
}