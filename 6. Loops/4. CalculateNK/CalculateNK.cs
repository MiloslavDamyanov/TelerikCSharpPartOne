﻿using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 0; i < n - k; i++)
        {
            factorial *= n - i;
        }
        Console.WriteLine(factorial);
    }
}
