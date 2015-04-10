using System;
class Factoriel
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        int firstNum = num;
        int factoriel = 1;
        
        for (int i = num; i >= 1; i--)
        {
            factoriel *= num;  //factoriel = factoriel * num;
            num--;
            
        }
        Console.WriteLine("{0}! = {1}", firstNum, factoriel);
    }
}
/*
using System;
class Factoriel
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal factorial = 1;

        while (true)
        {
            if (n <= 1)
            {
                break;
            }
            factorial *= n;
            n--;
        }
        Console.WriteLine("n! = " + factorial);

    }
}
*/
