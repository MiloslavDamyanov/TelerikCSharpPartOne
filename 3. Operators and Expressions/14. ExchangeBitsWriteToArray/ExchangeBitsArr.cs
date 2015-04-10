using System;

class ExchangeBitsArr
{
    static void Main()
    {
        Console.Write("Enter number 0...4 294 967 295: ");
        UInt32 num = Convert.ToUInt32(Console.ReadLine());

        int p = 4;
        int k = 5;
        int q = 20;

        for (int i = 0; i < k - 1; i++)
        {
            if ((num & (1 << p)) != (num & (1 << q)))
            {
                num = (uint)(num ^ (1 << p));
                num = (uint)(num ^ (1 << q));
            }
            p++;
            q++;
        }
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
    }
}

