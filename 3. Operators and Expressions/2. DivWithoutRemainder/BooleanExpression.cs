using System;

class BooleanExpression
{
    static void Main()
    {
        int number = 35;
        bool result = (number % 5 == 0) && (number % 7 == 0);

        Console.WriteLine(result);

    }
}

