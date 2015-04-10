using System;
using System.Numerics;

class DataType
{
    static void Main()
    {
        int @int = int.MaxValue;
        UInt16 @UInt16 = UInt16.MaxValue;
        UInt32 @UInt32 = UInt32.MaxValue;
        UInt64 @UInt64 = UInt64.MaxValue;
        uint @uint = uint.MaxValue;
        long @long = long.MaxValue;
        ulong @ulong = ulong.MaxValue;
        double @double = double.MaxValue;
        float @float = float.MaxValue;
        byte @byte = byte.MaxValue;


        Console.WriteLine("\nint:    {0:0 000 000 000}\n", @int);
        Console.WriteLine("UInt:   {0:0 000 000 000}\n", @uint);
        Console.WriteLine("UInt16: {0:00 000}\n", @UInt16);
        Console.WriteLine("UInt32: {0:0 000 000 000}\n", @UInt32);
        Console.WriteLine("UInt64: {0:00 000 000 000 000 000 000}\n", @UInt64);
        Console.WriteLine("long:   {0:0 000 000 000 000 000 000}\n", @long);
        Console.WriteLine("ulong   {0:00 000 000 000 000 000 000}\n", @ulong);
        Console.WriteLine("double: {0}\n", @double);
        Console.WriteLine("float:  {0}\n", @float);
        Console.WriteLine("byte:   {0}\n", @byte);

    }
}

