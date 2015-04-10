using System;

class DeciamlToBin
{
    static void Main()
    {
        while (true)
        {
            Console.Write("N: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Convert.ToString(num, 2));
        }


    }
}

