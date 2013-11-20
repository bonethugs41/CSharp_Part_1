//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8  1+1-2=0.



using System;

class Program
{
    static void Main()
    {
        Console.Title = "Check if the sub sum of given 5 integers is zero";
        int[] Integer = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            while (true)
            {
                string[] Values = new string[5];
                Console.Write("Enter integer number {0}: ", i + 1);
                Values[i] = Console.ReadLine();
                bool IntResult = int.TryParse(Values[i], out Integer[i]);
                if (IntResult == true)
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid integer.", i + 1);
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            sum = Integer[i];
            for (int j = i + 1; j < 5; j++)
            {
                sum += Integer[j];
                if (sum == 0)
                {
                    Console.WriteLine("{0} + {1} = {2}", Integer[i], Integer[j], sum);
                }
                for (int k = j + 1; k < 5; k++)
                {
                    sum += Integer[k];
                    if (sum == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = {3}", Integer[i], Integer[j], Integer[k], sum);
                    }
                    for (int l = k + 1; l < 5; l++)
                    {
                        sum += Integer[l];
                        if (sum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", Integer[i], Integer[j], Integer[k], Integer[l], sum);
                        }
                        for (int m = l + 1; m < 5; m++)
                        {
                            sum += Integer[m];
                            if (sum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", Integer[i], Integer[j], Integer[k], Integer[l], Integer[m], sum);
                            }
                            sum -= Integer[m];
                        }
                        sum -= Integer[l];
                    }
                    sum -= Integer[k];
                }
                sum -= Integer[j];
            }
        }
    }
}