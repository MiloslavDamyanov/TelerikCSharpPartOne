using System;

class CheckThirdBit
{
    static void Main()
    {
        string bin;

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = ((number >> 3) & 1) == 1;

        Console.WriteLine("Third bit counting from 0 is: {0}", check ? "1" : "0");
        bin = Convert.ToString(number, 2);
        Console.WriteLine((bin).PadLeft(8, '0'));        
    }
}
