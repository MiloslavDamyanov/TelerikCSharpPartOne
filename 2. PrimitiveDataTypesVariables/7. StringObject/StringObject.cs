using System;

class StringObject
{
    static void Main()
    {
        string hi = "Hello";
        string wd = "World";
        object obj = hi + " " + wd;
        string valueObj;

        Console.WriteLine("\n\t{0}\n", valueObj = (string)obj);
        
    }
}
