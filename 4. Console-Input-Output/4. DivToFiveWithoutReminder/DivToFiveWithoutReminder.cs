using System;


class DivToFiveWithoutReminder
{
    static void Main()
    {
        int a;
        int b;
        int counter = 1;


        Console.WriteLine("Enter two integer numbers");
        Console.Write("First number: "); a = int.Parse(Console.ReadLine());
        Console.Write("Second number: "); b = int.Parse(Console.ReadLine());
        
        for (int i = a; i < b; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }

        }
        Console.WriteLine("There is {0} numbers '5' between {1} and {2}", counter, a, b);
    }
}


