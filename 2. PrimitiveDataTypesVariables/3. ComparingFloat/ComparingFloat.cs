using System;

class ComparingFloat
{
    static void Main()
    {
        float a = 5.3f;
        float b = 6.01f;
        float C = 5.00000001f;
        float D = 5.00000003f;

        bool equalab = (a == b);
        Console.WriteLine("\n\t5.3 is not equal to 6.01 the result is {0}", equalab);

        bool equalCD = (C == D);
        Console.WriteLine("\n\t5.00000001 is equal to 5.00000003 the result is {0}\n", equalCD);
    }
}

