using System;
using System.Globalization;
using System.Threading;

class CoffeeVendingMachine
{
    static void Main()
    {
        float[] coins = { 0.05F, 0.10F, 0.20F, 0.50F, 1.00F };
        int[] countOfcoins = new int[coins.Length];
        float coinsSum = 0;

        for (int i = 0; i < countOfcoins.Length; i++)
        {
            countOfcoins[i] = int.Parse(Console.ReadLine());
            coinsSum += coins[i] * countOfcoins[i];
        }

        float amount = float.Parse(Console.ReadLine());
        float price = float.Parse(Console.ReadLine());
        float addMoney = price - amount;
        float notEnoughChange = amount - (coinsSum + price);
        float moneyLeft = ((coinsSum + price) - amount);

        if (price > amount)
        {
            Console.WriteLine("More {0:0.00}", addMoney);
        }
        else if (price < amount && (coinsSum + price) < amount)
        {
            Console.WriteLine("No {0:0.00}", notEnoughChange);
        }
        else if (price < amount && (coinsSum + price) >= amount)
        {
            Console.WriteLine("Yes {0:0.00}", moneyLeft);
        }
    }
}