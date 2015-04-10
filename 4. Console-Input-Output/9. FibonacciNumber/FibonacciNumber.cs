using System;

class FibonacciNumber
{
    static void Main()
    {

        decimal n = 100, a = 0, b = 1;
        int i = 1;
        while (n-- != 0)
        {
            Console.WriteLine("{0}: {1}", i++, a);

            b = a + b;
            a = b - a;
        }
    }
}

