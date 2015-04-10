using System;

class MatrixArray
{
    static void Main()
    {
        int[,] matrix =
        {
        {1, 2, 3, 4, }, //row - ред 
        {5, 6, 7, 8},   //col - колона
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

