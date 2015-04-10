using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 25;

        Console.WriteLine("a={0}:   {1}", a, Convert.ToString(a, 2));
        Console.WriteLine("b={0}:{1}", b, Convert.ToString(b, 2));
        Console.WriteLine("{0}:^ {1}", b ^ a, Convert.ToString(b ^ a, 2));
        Console.WriteLine("{0}:~ {1}", b ^ a, Convert.ToString(~b ^ a, 2));
    }
}

