//Write a program that prints all the numbers from 1 to N.



using System;

class NumbersToN
{
    static void Main()
    {
        Console.Title = "Numbers from 1 to N";
        int n = 0;
        while (true)
        {
            Console.Write("Input N:");
            string check = Console.ReadLine();
            bool nCheck = int.TryParse(check, out n);
            if (nCheck == true)
            {
                break;
            }
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}