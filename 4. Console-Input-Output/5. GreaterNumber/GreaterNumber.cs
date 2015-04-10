using System;
using System.Threading;
using System.Globalization;

class GreaterNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a;
        double b;

        Console.WriteLine("Enter two numbers");
        Console.Write("First number: "); a = double.Parse(Console.ReadLine());
        Console.Write("Second number: "); b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater is: {0}", Math.Max(a, b));
    }
}

