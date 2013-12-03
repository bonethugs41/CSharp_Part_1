using System;

class Subset_sum
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int answer = 0;
        int maxI = (int)Math.Pow(n, 2) - 1;
        for (int i = 0; i <= maxI; i++)
        {
            long currentSum = 0;
            for (int j = 0; j <= n; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    if (j == 1) currentSum += numbers[0];
                    if (j == 2) currentSum += numbers[1];
                    if (j == 3) currentSum += numbers[2];
                    if (j == 4) currentSum += numbers[3];
                    if (j == 5) currentSum += numbers[4];
                    if (j == 6) currentSum += numbers[5];
                    if (j == 7) currentSum += numbers[6];
                    if (j == 8) currentSum += numbers[7];
                    if (j == 9) currentSum += numbers[8];
                    if (j == 10) currentSum += numbers[9];
                    if (j == 11) currentSum += numbers[10];
                    if (j == 12) currentSum += numbers[11];
                    if (j == 13) currentSum += numbers[12];
                    if (j == 14) currentSum += numbers[13];
                    if (j == 15) currentSum += numbers[14];
                    if (j == 16) currentSum += numbers[15];
                }
            }
            if (currentSum == s) answer++;
        }
        Console.WriteLine(answer);
    }
}
