//We are given integer number n, value v (v=0 or 1) and a position p.
//Write a sequence of operators that modifies n to hold the value v
//at the position p from the binary representation of n.



using System;

class BitValue
{
    static void Main()
    {
        Console.Title = "Assign value to a specific bit";
        Console.WriteLine("Input any number:");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bit position:");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bit value:");
        int bitValue;
        bool valueCheck = true;
        while (true)
        {
            bitValue = int.Parse(Console.ReadLine());
            if ((bitValue == 1) || (bitValue == 0))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid value, please enter 0 or 1:");
                continue;
            }
        }
        int newNumber;
        if (bitValue == 1)
        {
            int mask = 1 << bitPosition;
            newNumber = inputNumber | mask;
        }
        else
        {
            int mask = ~(1 << bitPosition);
            newNumber = inputNumber & mask;
        }
        Console.WriteLine("The new number is: {0}", newNumber);


        //Not necessary, shows the bit change.
        //string numberBinary = Convert.ToString(newNumber, 2).PadLeft(32, '0');
        //string oldNumberBinary = Convert.ToString(inputNumber, 2).PadLeft(32, '0');
        //Console.WriteLine("\n\n\n{0} \n{1}", oldNumberBinary, numberBinary);
    }
}