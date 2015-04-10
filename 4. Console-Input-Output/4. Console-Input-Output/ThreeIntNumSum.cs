using System;
using System.Text;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        int a, b, result;

        Console.Write("Enter number a : "); a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b : "); b = int.Parse(Console.ReadLine());
        result = a + b;
        Console.WriteLine("Sum of {0} + {1} = {2}", a, b, result);
    }
}

