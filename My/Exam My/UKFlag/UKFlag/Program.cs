using System;

class Ukflag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = 0;
        int innerDots = n / 2 - 1; ;

        //top
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('\\');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('/');
            Console.Write(new string('.', outerDots));


            Console.WriteLine();

            outerDots++;
            innerDots--;
        }
        //center
        Console.Write(new string('-', n / 2));
        Console.Write('*');
        Console.Write(new string('-', n / 2));
        Console.WriteLine();

        //botton
        innerDots = 0;
        outerDots = n / 2 - 1; ;

        for (int i = n / 2; i > 0; i--)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('/');
            Console.Write(new string('.', innerDots));
            Console.Write('|');
            Console.Write(new string('.', innerDots));
            Console.Write('\\');
            Console.Write(new string('.', outerDots));


            Console.WriteLine();

            outerDots--;
            innerDots++;
        }

    }
}

