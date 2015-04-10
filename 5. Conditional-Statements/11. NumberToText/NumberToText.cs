using System;

class NumberToText
{
    static string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
                               "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", 
                               "eighteen", "nineteen" };

    static string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    static string NumberToWords(int number)
    {
        string r = "";

        if (number > 99)
        {
            r += ones[number / 100] + " hundred";
            number %= 100;

            if (number != 0) r += " and ";
            else return r;
        }

        if (number > 19)
        {
            r += tens[number / 10 - 2];
            number %= 10;

            if (number != 0) r += " ";
            else return r;
        }

        r += ones[number];
        return r;
    }

    static void Main()
    {
        int[] number = { 1, 8, 0, 2, 3, 9, 8, 17, 20, 47, 52, 89, 143, 233, 367, 625, 999 };

        foreach (int i in number) Console.WriteLine(i + " => {0}", NumberToWords(i));
    }
}