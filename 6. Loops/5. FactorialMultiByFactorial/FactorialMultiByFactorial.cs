using System;

class FactorialMultiByFactorial
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 0; i < k; i++)
        {
            factorial *= n - i;

        }

        for (int i = 1; i <= k; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("factorial = {0}", factorial);
    }
}

