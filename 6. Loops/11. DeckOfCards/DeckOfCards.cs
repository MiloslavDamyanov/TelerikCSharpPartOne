using System;


class DeckOfCards
{
    static void Main()
    {
        string[] colors = { "♠ of spades", "♥ of hearts", "♦ of diamonds", "♣ of clubs" };
        string[] cards = { "Ace ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10 ", "Jack ", "Queen ", "King " };

        Console.WriteLine();
        for (int j = 0; j < colors.Length; j++)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine("{0}{1}", cards[i], colors[j]);
            }
            Console.WriteLine();
        }


    }
}

