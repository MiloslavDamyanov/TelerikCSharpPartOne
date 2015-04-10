using System;

class MissCat
{
    static void Main()
    {
        string n = Console.ReadLine();


        int judge = int.Parse(n);
        int[] cat = new int[11];
        int count = 1;

        for (int i = 1; i <= judge; i++)
        {
            int currentMark = int.Parse(Console.ReadLine());
            cat[currentMark] += count;

        }

        int max = 0;
        int result = 0;
        for (int i = 1; i < cat.Length; i++)
        {
            int currentValue = cat[i];
            if (max < currentValue)
            {
                max = currentValue;
                result = i;
            }

        }
        Console.WriteLine(result);
    }
}

