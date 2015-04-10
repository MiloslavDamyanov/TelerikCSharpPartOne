using System;

class CheckingPointCircle
{
    static void Main()
    {
        int radius = 5;

        Console.Write("Coordinate of the point x = ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Coordinate of the point y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool result = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2);

        Console.WriteLine(result ? "The points are inside of the circle" : "The points are outside of the circle");

    }

}

