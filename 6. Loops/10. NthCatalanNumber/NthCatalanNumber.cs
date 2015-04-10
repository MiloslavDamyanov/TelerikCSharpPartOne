using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("How many Catalan number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            BigInteger firstFactorial = 1;
            BigInteger secodFactorial = 1;
            BigInteger thirdFactorial = 1;
            int counter = 1;
            BigInteger catalan;
            int number = 0;

            Console.Write("Number {0}: ", i + 1);
            number = int.Parse(Console.ReadLine());

            while (counter <= (number * 2))
            {
                firstFactorial *= counter;
                counter++;
            }

            counter = 1;
            while (counter <= (number + 1))
            {
                secodFactorial *= counter;
                counter++;
            }

            counter = 1;
            while (counter <= number)
            {
                thirdFactorial *= counter;
                counter++;
            }

            catalan = (firstFactorial / (secodFactorial * thirdFactorial));
            Console.WriteLine("Catalan number is: {0}", catalan);
        }
    }
}

