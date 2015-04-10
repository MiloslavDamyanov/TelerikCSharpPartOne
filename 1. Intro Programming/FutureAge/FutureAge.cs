using System;

class FutureAge
{
    static void Main()
    {
        Console.WriteLine("\tPlease enter the year you were born:");
        string year = Console.ReadLine();
        int YearBorn = int.Parse(year);

        if (YearBorn > 1900 && YearBorn <= DateTime.Now.Year)
        {
            int AgeNow = DateTime.Now.Year - YearBorn;
            int futureAge = AgeNow + 10;
            Console.WriteLine("\n\tYou are now : " + AgeNow + " years old" );
            Console.WriteLine("\tAfter 10 years you will be : " + futureAge + " years old");
        }
        else
        {
            Console.WriteLine("\n\tIncorrect year !");
        }

    }
}