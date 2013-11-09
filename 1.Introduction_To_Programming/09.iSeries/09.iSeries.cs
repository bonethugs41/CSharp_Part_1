//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...


using System;

class NSeries
{
    public static int SeriesN(int n)
    {
        int a = 2;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            if (i % 2 == 0)
            {
                a = temp - (2 * temp + 1);      //Getting positive values of the series
            }
            else
            {
                a = temp - (2 * temp - 1);      //Getting negative values of the series
            }
        }
        return a;
    }
    static void Main()
    {
        Console.Title = "Number Series";
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine(SeriesN(i));
        }
    }
}