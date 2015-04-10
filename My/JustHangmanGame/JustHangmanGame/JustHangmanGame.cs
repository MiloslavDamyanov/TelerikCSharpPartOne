using System;

class JustHangmanGame
{
    static void Main()
    {
        string word = "champion";
        int count = 0;

        Console.WriteLine("Gues a word ! _ _ _ _ _ _ _ _");

        while (true)
        {
            Console.Write(": ");
            char ch = char.Parse(Console.ReadLine());


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    Console.WriteLine(word[i]);
                }
                
            }
        }
    }
}

