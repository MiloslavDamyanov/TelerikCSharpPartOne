using System;

class Program
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        long sum = 0;
        for (int i = 0; i < 75000000; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
        DateTime stopTime = DateTime.Now;
        Console.WriteLine(stopTime - startTime);
    }
}
