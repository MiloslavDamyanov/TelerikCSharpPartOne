using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int range = int.Parse(Console.ReadLine());
        int sum = 1;
        int num = 1;
        while (num < range)
        {
            num++;
            sum += num;
            Console.Write(" "+num);
        }
            Console.WriteLine(" = "+sum);
    }
}

