using System;
using System.Text;
using System.Threading;
using System.Globalization;

class Globalization
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


        Console.Write("Число 1: ");
        double a = double.Parse(Console.ReadLine());
        double number;
        Console.Write("Число 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("sum is {0}", a + b);



    }
}

