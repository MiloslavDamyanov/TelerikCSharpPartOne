using System;

class Program
{
    static void Main()
    {
       
            Random generatedNumber = new Random();

            int endGameNumber = generatedNumber.Next(1, 101);
            Console.WriteLine(endGameNumber);

            var rand = new Random();
           // while (true)
           // {
                double result = rand.Next() + rand.NextDouble();
                Console.WriteLine(result);
           // }

        
    }
}

