using System;

namespace Forest_Road
{
    class Program
    {
        static void Main()
        {
            string geeko = "*";
            string trees = ".";


            Console.Write("Please enter width of the map: "); int n = int.Parse(Console.ReadLine());
            if (n >= 2 && n <= 79)
            {

            }

            else
            {
                Console.WriteLine("The width must be positive integer between 2 and 79, inclusive.");
            }
            int mapHeight = 2 * n - 1;
        }
    }

}