using System;

class CalcSumWithAccuracy
{
    static void Main()
    {
        double a = 0;
        Console.Write("Enter integer number to end the sequence n = "); int end = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= end; i++)
        {
            a = a + ((double)1 / i);
        }
        Console.WriteLine("The sum of 1 + 1/2 + 1/3 + 1/4 ... + 1/n is {0:0.000}", a);
    }
}