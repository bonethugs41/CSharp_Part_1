//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).


using System;

class EucledeanAlgorithm
{
    static void Main(string[] args)
    {
        Console.Title = "Eucledean algorithm";
        int N;
        int K;
        while (true)
        {
            Console.Write("N = ");
            string Value = Console.ReadLine();
            bool ResultN = int.TryParse(Value, out N);
            Console.Write("K = ");
            Value = Console.ReadLine();
            bool ResultK = int.TryParse(Value, out K);
            if ((ResultN == true) && (ResultK == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        if (N < K)
        {
            int temp = N;
            N = K;
            K = temp;
        }
        int Remainder;
        while (K != 0)
        {
            Remainder = N % K;
            N = K;
            K = Remainder;
        }
        Console.WriteLine("The GCD is: {0}", N);
    }
}