﻿using System;

class PrintNumNotDivisible
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % (3 * 7) != 0)
            {
                Console.WriteLine(i);
            }
        }



    }
}

