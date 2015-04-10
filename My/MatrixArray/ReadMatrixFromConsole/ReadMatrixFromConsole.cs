using System;

class ReadMatrixFromConsole
{
    static void Main()
    {
        int rows;
        int cols;

        do
        {
            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());
            cols = rows;
        } while (rows < 1 || rows > 20);

        //декларираме масив с елемнти ред по колона row cols
        int[,] matrix = new int[rows, cols];

        //въвеждане ана лементи в матрицата 
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Matrix [ {0},{1} ]", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //отпечатване елементите на матрицата
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" " + matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

