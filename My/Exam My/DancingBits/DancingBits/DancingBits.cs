using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int numbers;
        string binaryNumber = null;


        for (int i = 0; i < n; i++)
        {
            numbers = int.Parse(Console.ReadLine());
            binaryNumber += Convert.ToString(numbers, 2);
        }

        char previousChar = binaryNumber[0];

        int count = 1;
        int endResult = 0;

        for (int i = 1; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == previousChar)
            {
                count++;
            }
            else
            {
                if (count == k)
                {
                    endResult++;
                }

                count = 1;
                previousChar = binaryNumber[i];
            }
        }

        if (count == k)
        {
            endResult++;
        }

        Console.WriteLine(endResult);

    }
}

