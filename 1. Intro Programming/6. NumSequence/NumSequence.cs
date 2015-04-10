using System;

class NumerSequence
{
    static void Main()
    {
        for (int i = 2; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("\t " + i);
            }
            else
            {
                Console.WriteLine("\t" + -i);
            }
        }
    }
}