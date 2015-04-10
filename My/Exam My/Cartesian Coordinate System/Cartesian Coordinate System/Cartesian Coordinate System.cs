using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        string coordinateX = Console.ReadLine();
        string coordinateY = Console.ReadLine();

        double pointX = double.Parse(coordinateX);

        double pointY = double.Parse(coordinateY);

        if (pointX == 0 && pointY == 0)
        {
            Console.WriteLine(0);
        }
        else if (pointX > 0 && pointY > 0)
        {
            Console.WriteLine(1);
        }
        else if (pointX < 0 && pointY > 0)
        {
            Console.WriteLine(2);
        }
        else if (pointX < 0 && pointY < 0)
        {
            Console.WriteLine(3);
        }
        else if (pointX > 0 && pointY < 0)
        {
            Console.WriteLine(4);
        }
        else if (pointX == 0)
        {
            Console.WriteLine(5);
        }
        else if (pointY == 0)
        {
            Console.WriteLine(6);
        }
        

    }
}

