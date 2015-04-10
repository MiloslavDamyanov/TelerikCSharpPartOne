using System;
using System.Text;
using System.Threading;
using System.Globalization;

class RadiusOfCirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double radius;
        double perimeter;
        double area;

        Console.Write("Enter radius of the circle:");
        radius = double.Parse(Console.ReadLine());

        area = Math.PI * (Math.Pow(radius, 2));
        perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Perimeter of this circle is: {0:0.00}\nArea of this circle is: {1:0.00}", perimeter, area);
    }
}
