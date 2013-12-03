using System;

class Forest_road
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int widht = n;
        int height = 2 * n - 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
                
            }
            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }

            }
            Console.WriteLine();
        }

    }
}