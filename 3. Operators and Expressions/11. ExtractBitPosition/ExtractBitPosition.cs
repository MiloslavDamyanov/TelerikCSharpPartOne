using System;
class ExtractBitPosition
{
    static void Main()
    {
        int Num = 5;
        int position = 2;

        int bit = (Num >> position & 1);

        Console.WriteLine(bit);
    }
}

