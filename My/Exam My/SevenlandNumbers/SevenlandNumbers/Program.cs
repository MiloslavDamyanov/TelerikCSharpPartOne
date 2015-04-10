using System;

class SevenlandNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int inputNumber = int.Parse(input);

        int powerCounter = 0;
        int decimalNumber = 0;

        while (inputNumber != 0)
        {
            byte lastNumber = (byte)(inputNumber % 10); //взимаме последното число 

            decimalNumber += lastNumber * (int)Math.Pow(7, powerCounter);
            powerCounter++;

            inputNumber /= 10;
        }
        decimalNumber++;
        string result = "";

        while (decimalNumber != 0)
        {
            byte lastNumber = (byte)(decimalNumber % 7);
            result = lastNumber + result;
            decimalNumber /= 7;
        }
        Console.WriteLine(result);
    }
}

