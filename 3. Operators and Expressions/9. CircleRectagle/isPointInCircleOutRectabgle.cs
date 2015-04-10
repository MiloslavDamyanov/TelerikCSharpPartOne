using System;

class isPointInCircleOutRectabgle
{
    static void Main()
    {
        Console.WriteLine("Enter point (x,y) ");

        Console.Write("Width x = ");
        double widthX = Convert.ToDouble(Console.ReadLine());

        Console.Write("Height y = ");
        double heightY = Convert.ToDouble(Console.ReadLine());

        int radius = 3;
        double xCircle = widthX - 1;
        double yCircle = heightY - 1;

        if (Math.Pow(xCircle, 2) + Math.Pow(yCircle, 2) <= Math.Pow(radius, 2))
        {
            if ((widthX > 5) || (widthX < -1) || (heightY < -1) || (heightY > 1))
            {
                Console.WriteLine("Point ({0},{1}) is inside the circle and out of the rectangle", widthX, heightY);
            }
            else
            {
                Console.WriteLine("Point ({0},{1}) is inside the circle and inside of the rectangle", widthX, heightY);
            }
        }
        else
        {
            Console.WriteLine("Poit ({0},{1}) is outside the circle", widthX, heightY);
        }

    }
}
