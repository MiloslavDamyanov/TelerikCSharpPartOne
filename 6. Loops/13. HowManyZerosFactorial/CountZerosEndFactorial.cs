using System;

class CountZerosEndFactorial
{
    static void Main()
    {
        long number;
        Console.Write("N: ");
        number = int.Parse(Console.ReadLine());
        int power = 1;
        long countOfZeros = 0;
        do
        {
            countOfZeros = countOfZeros + (number / (long)Math.Pow(5, power));
            power++;
        }
        while (Math.Pow(5, power) <= number);
        Console.WriteLine(countOfZeros);
    }
}

