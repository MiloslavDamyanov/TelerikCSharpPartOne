using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter some number: ");

        int number = Convert.ToInt32(Console.Read());

        Console.Write(number % 2 == 0 ? "The number is even\n" : "The number is odd\n");

    }
}