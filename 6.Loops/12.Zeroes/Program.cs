//* Write a program that calculates for given N how many trailing zeros
//present at the end of the number N!. Examples:
//                    N = 10  N! = 3628800  2
//                    N = 20  N! = 2432902008176640000  4



using System;

class Zeroes
{
    static void Main()
    {
        int N;
        while (true)
        {
            Console.Write("N = ");
            string Value = Console.ReadLine();
            bool ResultN = int.TryParse(Value, out N);
            if (ResultN == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        BigInteger fac = 1;
        for (int i = 1; i <= N; i++)
        {
            fac *= i;
        }
        int Zero = N / 5;
        Console.WriteLine("N! = {0}, has {1} zeros", fac, Zero);
    }
}