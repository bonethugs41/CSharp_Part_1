//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 



using System;

class NSum
{
    static void Main()
    {
        Console.Title = "Sum of N numbers";
        Console.Write("Input a positive number:");
        int nCount;
        double n;
        double sum = 0;
        while (true)
        {
            string value = Console.ReadLine();
            int.TryParse(value, out nCount);
            if (nCount > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("{0} is invalid number, please try again.", value);
            }
        }
        for (int i = 1; i <= nCount; i++)
        {
            while (true)
            {
                Console.Write("Input number {0}:", i);
                string value = Console.ReadLine();
                bool nResult = double.TryParse(value, out n);
                if (nResult == true)
                {
                    sum += n;
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is invalid numberm please try again.", value);
                }
            }
        }
        Console.WriteLine("The sum of the numbers is: {0}", sum);
    }
}