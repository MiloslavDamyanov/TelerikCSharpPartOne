using System;
using System.Text;

class CopyRighttrinagle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';
        char space = ' ';

        for (int i = 0; i <= 2; i++)
        {
            Console.Write(space);
        }

        Console.Write(copyRight);

        for (int i = 0; i <= 2; i++)
        {
            Console.Write(space);
        }

        Console.WriteLine();
        for (int i = 0; i <= 1; i++)
        {
            Console.Write(space);
        }
        for (int i = 0; i <= 2; i++)
        {
            Console.Write(copyRight);
        }

        for (int i = 0; i <= 1; i++)
        {
            Console.Write(space);
        }
        Console.WriteLine();

        Console.Write(space);
        for (int i = 0; i <= 4; i++)
        {
            Console.Write(copyRight);
        }
        Console.Write(space + "\n\n");

    }
}

