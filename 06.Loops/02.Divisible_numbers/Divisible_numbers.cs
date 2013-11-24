//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.



using System;

class DivisibleNumbers
{
    static void Main()
    {
        Console.Title = "Divisible by 3 and 7 numbers";
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
            if (!(i % (3 * 7) == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}