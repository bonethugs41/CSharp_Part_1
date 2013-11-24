//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


using System;

class Factorial
{
    static void Main()
    {
        Console.Title = "Factorial formula";
        decimal n;
        decimal k;
        while (true)
        {
            Console.Write("Input N:");
            string check = Console.ReadLine();
            bool nCheck = decimal.TryParse(check, out n);
            Console.Write("Input K:");
            check = Console.ReadLine();
            bool kCheck = decimal.TryParse(check, out k);
            if ((nCheck == true) && (kCheck == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers!");
            }
        }
        if ((n > k) || (k == 1) || (n == k) || (n == k))
        {
            Console.WriteLine("Wrong input! Тhe condition is not satisfied.");
            return;
        }

        // N!*K! / (K-N)! = N! * (K - (K - N))
        decimal nFact = 1;
        for (decimal i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }

        decimal resultRight = 1;
        for (decimal i = 0; i < (k - (k - n)); i++)
        {
            resultRight = resultRight * (k - i);
        }

        Console.WriteLine(nFact * resultRight);
    }
}