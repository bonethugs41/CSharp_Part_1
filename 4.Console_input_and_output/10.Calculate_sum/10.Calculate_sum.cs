//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...



using System;

class Program
{
    static void Main()
    {
        Console.Title = "Calculate the sum of 1 + 1/2 - 1/3 + ...";
        Console.Write("Enter how many numbers do you want to check:");
        int number = int.Parse(Console.ReadLine());
        double startNumber = 1;
        double totalSum = 1;
        for (double j = 2; j <= number; j++)
        {
            startNumber = 1;
            if (j % 2 == 0)
            {
                startNumber = startNumber / j;
            }
            else
            {
                startNumber = -(startNumber / j);
            }
            totalSum = totalSum + startNumber;
        }
        Console.WriteLine("The Total sum is: {0:F3}", totalSum);
    }
}