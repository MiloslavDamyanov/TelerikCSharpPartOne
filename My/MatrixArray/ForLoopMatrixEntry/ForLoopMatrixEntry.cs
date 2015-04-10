using System;

class ForLoopMatrixEntry
{
    static void Main()
    {
        int n = 3;
        int m = n;


        for (int j = 0; j < m; j++)
        {
            for (int i = j + 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            n += 1;
        }

    }
}

