using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter number 0...4 294 967 295: ");
        UInt32 num = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Binary representation: {0}", Convert.ToString(num, 2).PadLeft(32, '0'));

        uint temp1, temp2, bit1, bit2, swap;

        for (int pos1 = 3; pos1 < 6; pos1++)
        {
            int pos2 = pos1 + 21;

            temp1 = (uint)(1 << pos1);
            temp2 = (uint)(1 << pos2);
            bit1 = (num & temp1);
            bit2 = (num & temp2);

            if (bit1 == 0)
            {
                swap = (uint)(1 << pos2);
                num = (num & ~swap);
            }

            else
            {
                swap = (uint)(1 << pos2);
                num = (num | swap);
            }

            if (bit2 == 0)
            {
                swap = (uint)(1 << pos1);
                num = (num & ~swap);
            }

            else
            {
                swap = (uint)(1 << pos1);
                num = (num | swap);
            }

        }
        Console.WriteLine("After exchange bits: {0}\nBinary representation: {1}", num, Convert.ToString(num, 2).PadLeft(32, '0'));
    }
}