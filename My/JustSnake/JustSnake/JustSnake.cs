using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class JustSnake
{
    static void RemoveScrollBars()
    {
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;
    }

    struct Position
    {
        public int Row; //X
        public int col; //Y
        public Position(int row, int col) // int x, int y
        {
            this.Row = row;
            this.col = col;
        }
    }
    static void Main()
    {
        //Масив от посоки 
        Position[] directions = new Position[]
        {            //(ред колона)
            new Position (0, 1), // right - position +1 to right
            new Position (0,-1), // left - position -1 to left
            new Position (1, 0), // down
            new Position (-1, 0), // top
        };

        int direction = 0; // 0

        Queue<Position> SnakeElements = new Queue<Position>();

        //изписва не на конзолата
        for (int i = 0; i <= 5; i++)
        {
            SnakeElements.Enqueue(new Position(0, i)); //начални позиция на змията 0 1 2 3 4 5 
        }

        foreach (Position position in SnakeElements)
        {
            Console.SetCursorPosition(position.col, position.Row);
            Console.Write("*");
        }


        while (true)
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                direction = 1;
            }
            if (userInput.Key == ConsoleKey.RightArrow)
            {
                direction = 0;
            }
            if (userInput.Key == ConsoleKey.UpArrow)
            {
                direction = 3;
            }
            if (userInput.Key == ConsoleKey.DownArrow)
            {
                direction = 2;
            }

            RemoveScrollBars();
            Position snakeHead = SnakeElements.Last(); // връща последния елемент на опашката "главата на змията"
            SnakeElements.Dequeue(); // махаме първя въведен елемент във опашката на змията
            Position nextDirection = directions[direction]; //изместване
            Position snakeNewHead = new Position(snakeHead.Row + nextDirection.Row, snakeHead.col + nextDirection.col);
            SnakeElements.Enqueue(snakeNewHead); // слагаме новата позиция в опашката

            Console.Clear(); //изчистване на козолата да се махнат старите елемтни !!!
            //след преместване се изписва отново в конзолата 
            foreach (Position position in SnakeElements)
            {
                Console.SetCursorPosition(position.col, position.Row);
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
// видео 34.33 
