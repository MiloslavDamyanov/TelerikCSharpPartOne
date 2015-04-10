using System;

class Loops
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        while (counter < n)
        {
            counter++;
            Console.Write("{0} ", counter);
        }
        Console.WriteLine();
    }
}

