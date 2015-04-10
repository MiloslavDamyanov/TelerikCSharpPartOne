using System;

    class PrimeNumber
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            string numberAsString = Console.ReadLine();
            uint number = uint.Parse(numberAsString);
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                    Console.WriteLine(number);
                }
                divider++;
            }
            Console.WriteLine("Prime? {0}", prime);

        }
    }

