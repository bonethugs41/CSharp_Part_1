//Write a program that reads an integer number n from the console and
//prints all the numbers in the interval [1..n], each on a single line.



using System;

class NNumbers
{
    static void Main()
    {
        Console.Title = "Number from 1 to N";
        int number;
        while (true)
        {
            Console.Write("Input number:");
            string check = Console.ReadLine();
            int.TryParse(check, out number);
            if (number > 0)
            {
                break;
            }
            else
            {
                Console.Write("Invalid value, please another number:");
            }
        }
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}