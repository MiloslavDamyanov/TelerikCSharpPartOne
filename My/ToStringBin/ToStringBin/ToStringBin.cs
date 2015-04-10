using System;

class ToStringBin
{
    static void Main()
    {
        int result = 42;
        string bin;
        string hex;
        string oct;
        int dec;
        int i;
        int counter = 0;

        Console.WriteLine("Bin: {0}", Convert.ToString(result, 2).PadLeft(1, '0')); //(result,2) 2 mean type of num system in this case is Bin
        Console.WriteLine("Hex: {0}", Convert.ToString(result, 16).PadLeft(1, '0')); // 16 Hex ... 
        Console.WriteLine("Oct: {0}", Convert.ToString(result, 8).PadLeft(1, '0'));
        Console.WriteLine("Dec: {0}", result);

        //same code : 
        bin = Convert.ToString(result, 2).PadLeft(1, '0');
        hex = Convert.ToString(result, 16).PadLeft(1, '0');
        oct = Convert.ToString(result, 8).PadLeft(1, '0');
        dec = result;

        Console.WriteLine("\n{0}", bin);
        Console.WriteLine(hex);
        Console.WriteLine(oct);
        Console.WriteLine(dec);

        //method for comparing
        bool compare = bin.CompareTo(hex) == 0;
        Console.WriteLine("\n{0}", compare);

        //strings 
        string symbol = "";
        Console.WriteLine(symbol.PadRight(40, '-'));
        string word = "Miloslav Ivanov Damyanov";
        Console.WriteLine("\nThe length is {0} symbols", word.Length);


        Console.WriteLine("The first letter is : {0}\n", word[0]);

        for (i = 0; i < word.Length; i++)
        {
            Console.Write(word[i]);
            //брои букви а 
            if (word[i] == 'a')
            {
                counter++;
            }

        }

        Console.WriteLine("\n a = {0}\n", counter);
        Console.WriteLine(symbol.PadRight(40, '-'));

        //заделя памет за нов стринг str 
        string str = new string('@', 10);
        Console.WriteLine(str);

        Console.WriteLine(str is string); //проверка дали променливата е от даден тип 

        //ако b няма стойност изпиши "No value."
        string b = "\nValue\n";
        Console.WriteLine(b ?? "\nNo value.\n");

        Console.WriteLine(Math.E); 

    }
}

