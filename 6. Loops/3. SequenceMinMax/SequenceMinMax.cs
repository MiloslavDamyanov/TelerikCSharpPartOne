using System;

class SequenceMinMax
{
    static void Main()
    {
        int[] number = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            number[i] = int.Parse(Console.ReadLine());
        }

        //min value
        int minValue = number[0];
        for (int i = 0; i < 5; i++)
        {
            if (number[i] < minValue)
            {
                minValue = number[i];
            }
        }
        Console.WriteLine("Min value is: {0}", minValue);

        //max value
        int maxValue = 0;
        maxValue = number[0];
        for (int i = 0; i < 5; i++)
        {
            if (number[i] > maxValue)
            {
                maxValue = number[i];
            }
        }
        Console.WriteLine("Max value is: {0}", maxValue);
    }
}

