using System;

class Program
{
    static void Main()
    {
        int num1 = 0;
        int num2 = 1;
        int sum = 1;
        while (num1 <= 20)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            Console.WriteLine(num2);
        }
        Console.ReadLine();
    }

}

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34