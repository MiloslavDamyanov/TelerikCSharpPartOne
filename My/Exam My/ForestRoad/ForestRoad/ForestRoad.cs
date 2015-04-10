using System;

class ForestRoad
{
    static void Main()
    {
        char geeko = '*';
        char tree = '.';
        int count = 0;

        int n = int.Parse(Console.ReadLine());
        int mapHight = n;

        for (int row = 0; row < n; row++)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == row)
                {
                    Console.Write(geeko); //*
                }
                else
                {
                    Console.Write(tree); //...
                }
            }
            Console.WriteLine();
        }
       

        for (int row = mapHight-2; row >= 0; row--)
        {
            for (int i = 0; i < mapHight; i++)
            {
                if (i == row)
                {
                    Console.Write(geeko); //*
                }
                else
                {
                    Console.Write(tree); //...
                }
            }
            Console.WriteLine();
        }
       
        
    }
}

