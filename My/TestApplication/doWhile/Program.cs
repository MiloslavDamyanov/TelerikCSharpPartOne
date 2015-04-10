using System;

    class Program
    {
        static void Main()
        {
            int i = 11;
            do
            {
                i--;
                Console.Write("{0} ",i);
            } while (i > 1);

            Console.WriteLine();

            int j = 0;
            do
            {
                j++;
                Console.Write("{0} ", j);
                
            } while (j < 10);

        }
    }

