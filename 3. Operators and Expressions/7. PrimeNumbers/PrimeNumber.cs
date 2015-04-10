
using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter some number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0 || n > 100)
        {
            Console.WriteLine("Out of range 0...100 !");
        }
        else
        {
            int div = 2;
            int maxDiv = (int)Math.Sqrt(n);
            bool prime = true;

            while (prime && (div <= maxDiv))
            {
                if (n % div == 0)
                {
                    prime = false;
                }
                div++;
            }
            Console.WriteLine(prime == true ? "this number is prime !" : "this number is not prime !");

        }

    }
}
