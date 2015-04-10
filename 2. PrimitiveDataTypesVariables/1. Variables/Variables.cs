using System;


class Variables
{
    static void Main()
    {
        byte byteNum = 97;         // 0 to 255
        sbyte sbyteNum = -115;     //-128 to 127
        uint uIntNum = 4825932;    //0 to 4,294,967,295
        short shortNum = -10000;   //-32,768 to 32,767
        ushort uShortNum = 52130;  //0 to 65,535

        Console.WriteLine("\n\tbyte {0}, sbyte {1}, uint {2}\n\n\tshort {3}, ushort {4}\n", byteNum, sbyteNum, uIntNum, shortNum, uShortNum);
    }
}

