using System;

class QuadraticEquation
{
    static void Main()
    {
        int a, b, c;
        double x1, x2;
        double d;
        Console.WriteLine("Quadratic equation \"ax^2+bx+c=0\"");

        Console.Write("a = "); a = int.Parse(Console.ReadLine());
        Console.Write("b = "); b = int.Parse(Console.ReadLine());
        Console.Write("c = "); c = int.Parse(Console.ReadLine());

        d = (Math.Pow(b, 2) - (4 * a * c));
        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("The equation has two roots x1= {0} and x2= {1}", x1, x2);
        }
        else if (d == 0)
        {
            int x = -b / (2 * a);
            Console.WriteLine("The equation has one root x= {0}", x);
        }
        else
        {
            Console.WriteLine("The equation has no real roots");
        }
    }
}

