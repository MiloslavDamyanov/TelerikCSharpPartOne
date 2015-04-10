using System;

class CalcPrintSquare
{
    static void Main()
    {
        Console.WriteLine("\tSquare root of 12345 is :\n");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("\t" + i + "= " + Math.Sqrt(i));
        }
        Console.WriteLine("\n\tSquare of 12345 is: " + Math.Pow(12345,2));
    }
}

