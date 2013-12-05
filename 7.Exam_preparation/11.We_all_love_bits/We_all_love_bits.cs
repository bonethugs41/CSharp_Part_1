using System;

class BitLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
            int reversed = Convert.ToInt32(binary);
            Console.WriteLine(reversed);

        }
    }
}