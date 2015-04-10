using System;

class QuadraticEquation
{
    static void Main()
    {
        int valueA, valueB, ValueC;
        double x1, x2;
        double discriminant;
        Console.WriteLine("Quadratic equation \"ax^2+bx+c=0\"");

        Console.Write("a = "); valueA = int.Parse(Console.ReadLine());
        Console.Write("b = "); valueB = int.Parse(Console.ReadLine());
        Console.Write("c = "); ValueC = int.Parse(Console.ReadLine());

        discriminant = (Math.Pow(valueB, 2) - (4 * valueA * ValueC));
        if (discriminant > 0)
        {
            x1 = (-valueB + Math.Sqrt(discriminant)) / (2 * valueA);
            x2 = (-valueB - Math.Sqrt(discriminant)) / (2 * valueA);
            Console.WriteLine("The equation has two roots x1= {0} or x2= {1}", x1, x2);
        }
        else if (discriminant == 0)
        {
            int x = -valueB / (2 * valueA);
            Console.WriteLine("The equation has one root x= {0}", x);
        }
        else
        {
            Console.WriteLine("The equation has no real roots");
        }
    }
}

