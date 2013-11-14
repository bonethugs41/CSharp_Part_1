//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1  false.



using System;

class RandomBit
{
    static void Main()
    {
        Console.Title = "Random bit position";
        Console.WriteLine("Input any number:");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of the bit you want to check if 1?");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bitPosition;
        int numberAndMask = inputNumber & mask;
        int bit = numberAndMask >> bitPosition;
        bool check = (bit == 1);
        Console.WriteLine(check);
    }
}
