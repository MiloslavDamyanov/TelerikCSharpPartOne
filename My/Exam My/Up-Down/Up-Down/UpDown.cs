using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Up Down Game");
        Console.WriteLine("try to guess the number from (1 to 100)");

        Random generatedNumber = new Random();

        int endGameNumber = generatedNumber.Next(1, 101); // izvajda sledvashtoto random chislo ot 1 do 100 !
        int minimum = 1;
        int maximum = 100;

        while (true)
        {
            Console.WriteLine("Enter number between {0} and {1} : ", minimum, maximum);


            string readNumberString = Console.ReadLine();
            int userNumber;

            bool parsedNumber = int.TryParse(readNumberString, out userNumber);

            if (!parsedNumber)
            {
                Console.WriteLine("Invalid number");
                continue;
            }

            if (userNumber == endGameNumber)
            {
                Console.WriteLine("Congratulations. You won !");
                break;
            }
            else if (userNumber > endGameNumber)
            {
                maximum = userNumber - 1;
                Console.WriteLine("DOWN !!!");
            }
            else if (userNumber < endGameNumber)
            {
                minimum = userNumber + 1;
                Console.WriteLine("UP !!!");
            }
        }
    }
}

