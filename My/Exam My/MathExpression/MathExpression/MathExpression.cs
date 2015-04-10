using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double result;
        double mod = m * 180;
        const double number = 128.523123123;
        const double numberNom = 1337;
        result = ((((Math.Pow(n, 2) + 1 /( m * p)) + numberNom)) / (n - number * p)) + Math.Sin((int)m % 180);
        Console.WriteLine("{0:F6}", result);

            
    }
}

