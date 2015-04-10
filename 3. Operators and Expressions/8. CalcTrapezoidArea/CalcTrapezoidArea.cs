using System;

class CalcTrapezoidArea
{
    static void Main()
    {
        int sideA = 8;
        int sideB = 4;
        int height = 2;
        int Area = ((sideA + sideB) * height) * 1 / 2;
        Console.WriteLine("Area is : {0} cm.", Area);

    }
}
