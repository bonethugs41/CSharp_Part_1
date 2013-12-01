using System;

class TripleRotation
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i < 4; i++)
        {
            int lastDigit = number % 10;
            number = number / 10;
            string result1 = lastDigit.ToString() + number.ToString();
            number = int.Parse(result1);
        }
        Console.WriteLine(number);
    }
}