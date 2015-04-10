using System;

class Program
{
    static void Main()
    {
        byte a = 3;
        byte b = 5;

        Console.WriteLine("\n\t(a | b)   {0}  // {1}", (a | b), Convert.ToString(a | b, 2).PadLeft(8, '0')); //00000111
        Console.WriteLine("\t(a & b)   {0}  // {1}", (a & b), Convert.ToString(a & b, 2).PadLeft(8, '0'));   //00000001
        Console.WriteLine("\t(a ^ b)   {0}  // {1}", (a ^ b), Convert.ToString(a ^ b, 2).PadLeft(8, '0'));   //00000110
        Console.WriteLine("\t(~a & b)  {0}  // {1}", (~a & b), Convert.ToString(~a & b, 2).PadLeft(8, '0')); //00000100

        Console.WriteLine("\n\tПобитово изместване << >> със зададена позиция  \n\t(a=3 {0})\n", Convert.ToString(a, 2).PadLeft(8, '0'));
        Console.WriteLine("\t(a << 1)  {0}  // {1}", (a << 1), Convert.ToString(a << 1, 2).PadLeft(8, '0'));    //00000110
        Console.WriteLine("\t(a << 2) {0}  // {1}", (a << 2), Convert.ToString(a << 2, 2).PadLeft(8, '0'));     //00001100
        Console.WriteLine("\t(a >> 1)  {0}  // {1}\n", (a >> 1), Convert.ToString(a >> 1, 2).PadLeft(8, '0'));  //00000001

    }
}

