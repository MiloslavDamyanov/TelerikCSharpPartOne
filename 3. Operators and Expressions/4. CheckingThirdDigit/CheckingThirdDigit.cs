using System;

class CheckingThirdDigit
{
    static void Main()
    {
        int number = 1732;
        bool digit = ((number / 100) % 10) == 7;

        //with string
        int num = 2756;
        string convertedNum = Convert.ToString(num);
        Console.WriteLine(convertedNum[1] == '7' ? true : false);

    }
}
