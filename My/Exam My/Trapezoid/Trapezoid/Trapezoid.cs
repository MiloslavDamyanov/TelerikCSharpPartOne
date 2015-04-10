using System;

class Trapezoid
{
    static void Main()
    {
        int width;
        int height;
        char dot = '.';
        char star = '*';
        
        int n = int.Parse(Console.ReadLine());
        int count = (2 * n - 1);
        //top..........**********
        for (int i = 0; i < n; i++)
        {
            Console.Write(dot);
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(star);
        }
        Console.WriteLine();
        //----------------------

        for (int row = 1; row < n; row++)
        {
            for (int i = row; i < n; i++)
            {
                Console.Write(dot);
            }
            Console.Write(star);
            
            for (int i = n; i < count; i++)
            {
                Console.Write(dot);
                
            }
            Console.Write(star);
            count++;
            Console.WriteLine();
        }
        //bottom ********************
        for (int i = 0; i < (2 * n); i++)
        {
            Console.Write(star);
        }

    }
}


