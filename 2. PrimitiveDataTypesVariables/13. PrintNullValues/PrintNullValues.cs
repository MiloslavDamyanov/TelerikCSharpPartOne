using System;
class PrintNullValues
{
    static void Main()
    {
        int? someInteger = null;
        double? someDouble = null;

        Console.WriteLine("Integer value null =>{0}", someInteger);
        Console.WriteLine("Double value null =>{0}", someDouble);

        someInteger = 5;
        someDouble = 10.6;
        Console.WriteLine("5 + 10.6 = {0}", someInteger + someDouble);
        someDouble = null;
        Console.WriteLine(someInteger + someDouble);


    }
}
