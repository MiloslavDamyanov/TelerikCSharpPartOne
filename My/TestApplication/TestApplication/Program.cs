
using System;

class Program
{
    static void Main()
    {
        Console.Write("n: ");
        string consoleInPut = Console.ReadLine();
        int n;
        int sum = 1;
        int number = 1;

        while (!int.TryParse(consoleInPut, out n) || n < 1)
        {
            Console.Write("n: ");
            consoleInPut = Console.ReadLine();
        }
        while (number <= n)
        {
            number++;
            sum += number;
            Console.Write(" {0}", number);
        }
        Console.WriteLine(" = {0}", sum);
    }
}

