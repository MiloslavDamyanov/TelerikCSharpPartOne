using System;


class StringQuoatations
{
    static void Main()
    {
        string withQuotedString = @"The ""use"" of quotations causes difficulties.";
        string withOutQuotedString = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine(withQuotedString);
        Console.WriteLine(withOutQuotedString);
    }
}

