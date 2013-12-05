using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger Tr1 = int.Parse(Console.ReadLine());
        BigInteger Tr2 = int.Parse(Console.ReadLine());
        BigInteger Tr3 = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger TrN = 0;
        if (n > 3)
        {
            for (int i = 4; i <= n; i++)
            {
                TrN = Tr1 + Tr2 + Tr3;
                Tr1 = Tr2;
                Tr2 = Tr3;
                Tr3 = TrN;
            }
            Console.WriteLine(TrN);
        }
        else
        {
            switch (n)
            {
                case 1: Console.WriteLine(Tr1);
                    {
                        break;
                    }
                case 2: Console.WriteLine(Tr2);
                    {
                        break;
                    }
                case 3: Console.WriteLine(Tr3);
                    {
                        break;
                    }
            }
        }
    }
}