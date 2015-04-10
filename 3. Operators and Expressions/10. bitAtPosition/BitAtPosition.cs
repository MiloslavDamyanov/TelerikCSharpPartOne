using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int position = Convert.ToInt32(Console.ReadLine());

        bool bit = ((value >> position) & 1) == 1;
        Console.WriteLine(bit);

    }
}


