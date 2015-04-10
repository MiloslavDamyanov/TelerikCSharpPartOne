using System;

class BiggestNumber
{
    static void Main()
    {

        Console.WriteLine("Enter Three integer numbers");
        Console.Write("First number: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Third number: "); int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

