using System;
using System.Globalization;
using System.Threading;

class GreatestValue
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double[] array = new double[5];
        double tempMax = 0;
        double maxValue = array[0];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Value {0}: ", i + 1); array[i] = double.Parse(Console.ReadLine());
        }


        for (int i = 1; i < 5; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                tempMax = i;
            }
        }
        Console.WriteLine("Max value is: {0}", maxValue);
    }
}

