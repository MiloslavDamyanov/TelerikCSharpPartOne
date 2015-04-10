using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double n;
        int c;
        int count = 1;
        double sum = 0;

        Console.Write("How many numbers you want to sum: "); c = int.Parse(Console.ReadLine());

        for (int i = 0; i < c; i++)
        {
            Console.Write("Number {0}: ", count++); sum += n = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("sum is: {0:0.00}", sum);
    }
}

