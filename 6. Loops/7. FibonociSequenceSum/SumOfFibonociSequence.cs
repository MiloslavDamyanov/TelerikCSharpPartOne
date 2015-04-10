using System;

class SumOfFibonociSequence
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        int sum = 1;
        
        for (int i = 1; i < n / 2; i++)
        {
            first = first + second;
            second = second + first;
            sum += first + second;

        }
        if (n % 2 != 0)
        {
            first = first + second;
            sum = sum + first;

        }
        Console.WriteLine("Sum is: {0}", sum);

    }
}

