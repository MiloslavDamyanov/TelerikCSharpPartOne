using System;
using System.Threading;
using System.Globalization;

class IntDoubleOrStringInput
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Choose variable type int, double or string: \n(1) Integer \n(2) Double \n(3) String");
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                {
                    Console.Write("Please enter integer number: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} + 1 = {1}\n", intNumber, intNumber + 1);
                } break;
            case 2:
                {
                    Console.Write("Please enter double number: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} + 1 = {1}\n", doubleNumber, doubleNumber + 1);
                } break;
            case 3:
                {
                    char symbol = '*';
                    Console.Write("Enter string: ");
                    string @string = Console.ReadLine();
                    Console.WriteLine("\"{0}\" append * = {1}\n", @string, @string + symbol);
                }break;
            default: Console.WriteLine("Choose 1, 2 or 3 ");
                break;
        }
    }
}

