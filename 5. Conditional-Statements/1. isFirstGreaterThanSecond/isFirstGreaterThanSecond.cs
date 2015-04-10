using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers to compare");
        Console.Write("Enter first number: "); int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: "); int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("First number is greater");
            int temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }
        else
        {
            Console.WriteLine("Second number is greater");
        }

    }


}

