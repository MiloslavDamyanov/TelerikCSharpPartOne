using System;

class NestedLoop
{
    static void Main()
    {
        Console.Write("number: ");
        int number = int.Parse(Console.ReadLine());
        DateTime startTime = DateTime.Now;

        for (int row = 1; row <= number; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("{0} ", column);
            }
            DateTime stopTime = DateTime.Now;

            Console.WriteLine(stopTime - startTime);
        }
    }
}

