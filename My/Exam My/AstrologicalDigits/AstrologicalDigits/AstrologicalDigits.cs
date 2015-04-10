using System;
using System.Threading;
using System.Globalization;

class AstrologicalDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string number = Console.ReadLine();

        int sum = 0;

        while (true)
        {

            for (int i = 0; i < number.Length; i++)
            {
                if (!(number[i] == '.' || number[i] == '-'))
                {
                    sum += int.Parse(number[i].ToString());
                }
            }
            if (sum < 10)
            {
                break;
            }
            number = sum.ToString();
            sum = 0;
        }
        Console.WriteLine(sum);
    }
}

