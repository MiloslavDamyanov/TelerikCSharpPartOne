using System;

class DescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three  numbers");
        Console.Write("First number: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Third number: "); int c = int.Parse(Console.ReadLine());

        if (a > b && b > c)
        {
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
        else if (a > c && c > b)
        {
            Console.WriteLine("{0}, {1}, {2}", a, c, b);
        }
        else if (b > a && a > c)
        {
            Console.WriteLine("{0}, {1}, {2}", b, a, c);
        }
        else if (b > c && c > a)
        {
            Console.WriteLine("{0}, {1}, {2}", b, c, a);
        }
        else if (c > b && b > a)
        {
            Console.WriteLine("{0}, {1}, {2}", c, b, a);
        }
        else if (c > a && a > b)
        {
            Console.WriteLine("{0}, {1}, {2}", c, a, b);
        }

    }
}
//another way to solve is with sorting algoritms 
