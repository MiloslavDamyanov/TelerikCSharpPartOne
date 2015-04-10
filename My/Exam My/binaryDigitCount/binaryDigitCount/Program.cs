using System;

class BinDigitCount
{
    static void Main()
    {
        byte B = byte.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long number;
        string strNumber;
        int[] zeros = new int[N];
        int[] ones = new int[N];

        int zeroCount = 0;
        int oneCount = 0;

        for (int i = 0; i < N; i++)
        {
            number = long.Parse(Console.ReadLine());

            strNumber = Convert.ToString(number, 2);

            for (int j = 0; j < strNumber.Length; j++)
            {
                if (B == 0 && strNumber[j] == '0')
                {
                    zeroCount++;
                }
                else if (B == 1 && strNumber[j] == '1')
                {
                    oneCount++;
                }
            }
            ones[i] = oneCount;
            zeros[i] = zeroCount;
            oneCount = 0;
            zeroCount = 0;
        }

        if (B == 0)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(zeros[i]);
            }
        }

        else if (B == 1)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(ones[i]);
            }
        }

    }
}
