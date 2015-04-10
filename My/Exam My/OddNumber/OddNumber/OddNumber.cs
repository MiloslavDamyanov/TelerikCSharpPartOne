using System;

class OddNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        int N = int.Parse(input);

        long currentNumber, count = 0;

        for (int i = 0; i < N; i++)
        {

            input = Console.ReadLine();
            currentNumber = long.Parse(input);
            count ^= currentNumber;

        }
        Console.WriteLine(count);
    }
}

/*
 Да вземем предвид числото 5, което в двоично представяне е 101

Ако това число го има четен брой път:

101^101 = 000

Ако това число го има нечетен брой пъти:

101^101^101 = 101

Няма значение в какъв ред се въвеждат числата рано или късно ще се анулират ако са четни и съотвено важното в условието е, че има само едно число, което се среща нечетен брой пъти!

 */