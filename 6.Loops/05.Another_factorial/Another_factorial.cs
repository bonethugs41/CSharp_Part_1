//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {

        //For the safty of your computer DO NOT enter too big numbers :D

        Console.Title = "Factorial formula";
        BigInteger n;
        BigInteger k;

        //check
        while (true)
        {
            Console.Write("Input N:");
            string check = Console.ReadLine();
            bool nCheck = BigInteger.TryParse(check, out n);
            Console.Write("Input K:");
            check = Console.ReadLine();
            bool kCheck = BigInteger.TryParse(check, out k);
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

        //!(K-N)
        BigInteger kMinusN = k - n;
        BigInteger factorialKMinusN = 1;
        while (kMinusN != 1)
        {
            factorialKMinusN *= kMinusN;
            kMinusN--;
        }

        //!N
        BigInteger factorialN = 1;
        while (n != 1)
        {
            factorialN *= n;
            n--;
        }

        //!K
        BigInteger factorialK = 1;
        while (k != 1)
        {
            factorialK *= k;
            k--;
        }

        BigInteger result = (factorialK * factorialN) / factorialKMinusN;
        Console.WriteLine("Result is: \n{0}", factorialKMinusN);
    }
}