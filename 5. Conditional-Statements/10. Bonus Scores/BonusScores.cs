using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter scroes in range [1..9]: ");
        string scores = Console.ReadLine();

        int number;
        if (int.TryParse(scores, out number))
        {
            int intScores = int.Parse(scores);
            if (intScores > 0 && intScores <= 3)
            {
                Console.WriteLine(intScores * 10);
            }
            else if (intScores > 3 && intScores <= 6)
            {
                Console.WriteLine(intScores * 100);
            }
            else if (intScores > 6 && intScores <= 9)
            {
                Console.WriteLine(intScores * 1000);
            }
            else
            {
                Console.WriteLine("not in range !");
            }
        }
        else
        {
            Console.WriteLine("this is not a number");
        }
    }
}

