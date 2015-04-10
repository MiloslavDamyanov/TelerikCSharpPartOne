using System;

class PrintsNumberInterval
{
    static void Main()
    {
        int n;
        Console.Write("Enter end number: "); n = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}
