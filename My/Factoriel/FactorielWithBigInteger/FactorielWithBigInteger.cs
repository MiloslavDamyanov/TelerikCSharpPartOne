using System;
using System.Numerics;

class FactorielWithBigInteger
{
    static void Main()
    {
        Console.Write("Enter a number to calculate factoriel: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger factoriel = 1;
        while (true)
        {
            if (number <= 1)
            {
                break;
            }
            factoriel *= number;
            number--;
        }

        Console.Write(factoriel+"\n");
    }
}

