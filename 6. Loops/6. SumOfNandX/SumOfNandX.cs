using System;

class SumOfNandX
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double count = 1;

        for (double i = 1; i <= n; i++)
        {
            sum += count *= i / x;
        }
        Console.WriteLine(sum);
    }
}
