using System;

class ChangeNumWithBitPositionAndValue
{
    static void Main()
    {
        int number = 35;
        int position = 2;
        int value = 1;

        int mask = value << position;

        number = number & (~(1 << position));
        number = number | (value << position);
        Console.WriteLine(number);
    }
}

