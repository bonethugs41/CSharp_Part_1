//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.



using System;

class MinMax
{
    static void Main()
    {
        Console.Title = "Minimal and maximal numbers";
        int n = 0;
        while (true)
        {
            Console.Write("Input N:");
            string check = Console.ReadLine();
            bool nCheck = int.TryParse(check, out n);
            if (true)
	        {
		        break;
	        }
        }
        int[] integer = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                string[] checks = new string[n];
                checks[i] = Console.ReadLine();
                bool intCheck = int.TryParse(checks[i], out integer[i]);
                if (intCheck == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid integers!");
                }
            }
        }
        int min = integer[0];
        int max = integer[0];
        for (int i = 0; i < n; i++)
        {
            if (min < integer[i])
            {
                min = integer[i];
            }
            if (max > integer[i])
            {
                max = integer[i];
            }
        }
        Console.WriteLine("The maximal number is:\n{0}", max);
        Console.WriteLine("The minimal number is:\n{0}", min);
    }
}