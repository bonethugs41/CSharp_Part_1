using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString('*').PadLeft((n - 1), '.').PadRight((2 * n - 3), '.'));
        int m = 3;
        string asterisk;
        string dot;
        int row = n - 3;
        for (int i = 1; i <= n-2; i++)
        {
            dot = new string('.', row);
            asterisk = new string('*', m);
            Console.WriteLine("{0}{1}{0}", dot, asterisk);
            m = m + 2;
            row--;
        }
        Console.WriteLine(Convert.ToString('*').PadLeft((n - 1), '.').PadRight((2 * n - 3), '.'));
    }
}