using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        int temp;

        Console.WriteLine("Enter two numbres to find greatest common divisor");

        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        while (firstNumber != 0)
        {
            temp = firstNumber;
            firstNumber = secondNumber % firstNumber;
            secondNumber = temp;
        }
        Console.WriteLine("Greatest common divisor is: {0}",secondNumber);
    }
}

