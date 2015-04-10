using System;

class ASCIItable
{
    static void Main()
    {
        int symbol = 0;

        for (int i = 0; i <= 127; i++)
        {
            Console.Write(" {0}", (char)symbol++);

        }

        Console.WriteLine("\n\nExtended ASCII Codes\n");

        for (int i = 128; i <= 255; i++)
        {
            Console.Write(" {0}", (char)symbol++);
        }
    }
}
