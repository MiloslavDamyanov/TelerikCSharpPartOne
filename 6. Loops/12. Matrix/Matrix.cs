using System;

class Matrix
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter positive integer number in range [1..20]");
            n = int.Parse(Console.ReadLine());
        } while (n < 1 || n > 20);

        int m = n;

        for (int j = 0; j < m; j++)
        {
            for (int i = j + 1; i <= n; i++)
            {
                if (i <= 9)
                {
                    Console.Write("  {0}", i);
                }
                else
                {
                    Console.Write(" {0}", i);
                }
            }
            Console.WriteLine();
            n += 1;
        }
    }
}

