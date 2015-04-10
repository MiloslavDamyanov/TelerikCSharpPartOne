using System;

class PositiveOrNegative
{


    static void Main()
    {
        int firstNum, secondNum, thirdNum, negativeCount = 0;
        Console.Write("first number: ");    firstNum = int.Parse(Console.ReadLine());
        Console.Write("second number: ");   secondNum = int.Parse(Console.ReadLine());
        Console.Write("third number");      thirdNum = int.Parse(Console.ReadLine());

        if (firstNum < 0)
        {
            negativeCount++;
        }
        if (secondNum < 0)
        {
            negativeCount++;
        }
        if (thirdNum < 0)
        {
            negativeCount++;
        }
        if (negativeCount > 1)
        {
            Console.WriteLine("the product is negative sign");
        }
        else
        {
            Console.WriteLine("the product positive sign");
        }
    }
}
