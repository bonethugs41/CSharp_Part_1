//Write a program that calculates N!/K! for given N and K (1<K<N).



using System;

class FactorialDivision
{
    static void Main()
    {
        Console.Title = "Factorial division";
        int n;
        while (true)
        {
            Console.Write("Input N:");
            string check = Console.ReadLine();
            bool nCheck = int.TryParse(check, out n);
            if (nCheck == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        int k;
        while (true)
        {
            Console.Write("Input K:");
            string check = Console.ReadLine();
            bool kCheck = int.TryParse(check, out k);
            if (kCheck == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        if ((n < k) || (k == 1) || (n == 1))
        {
            Console.WriteLine("Wrong input! Тhe condition is not satisfied.");
            return;
        }
        int result = 1;
        for (int i = 0; i < (n - k); i++)
        {
            result = result * (n - i);
        }
        Console.WriteLine("Result: \n{0}", result);
    }
}