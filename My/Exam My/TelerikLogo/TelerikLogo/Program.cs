using System;

class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        char dot = '.';
        char star = '*';

        int width = ((X + X) + (X / 2 + 1) + (X / 2 + 1) - 3);
        int hornsLenght = X / 2;
        int middleDots = width - 2 * (X / 2 + 1);

        Console.Write(new string(dot, hornsLenght));
        Console.Write(star);
        Console.Write(new string(dot, middleDots));
        Console.Write(star);
        Console.WriteLine(new string(dot, hornsLenght));


        middleDots -= 2;
        int firtHornDots = X / 2 - 1;
        int dotAfterHorn = 0;

        for (int rows = 1; rows < X - 1; rows++)
        {   // add real horns 

            if (rows <= X / 2)
            {
                Console.Write(new string(dot, firtHornDots));
                Console.Write(star);
                Console.Write(new string(dot, dotAfterHorn));

            }
            else
            {
                Console.Write(new string(dot, hornsLenght));
            }


            Console.Write(new string(dot, rows));
            Console.Write(star);
            Console.Write(new string(dot, middleDots));
            Console.Write(star);
            Console.Write(new string(dot, rows));

            middleDots -= 2;

            //add real horns
            if (rows <= X / 2)
            {
                Console.Write(new string(dot, dotAfterHorn));
                Console.Write(star);
                Console.Write(new string(dot, firtHornDots));
                firtHornDots--;
                dotAfterHorn++;
            }
            else
            {
                Console.Write(new string(dot, hornsLenght));
            }

            Console.WriteLine();

        }

        Console.Write(new string(dot, width / 2));
        Console.Write(star);
        Console.Write(new string(dot, width / 2));
        Console.WriteLine();

        // center part
        int leftRightDots = X - 2;
        middleDots = 1;

        for (int rows = 0; rows < X - 1; rows++)
        {   //left dots
            Console.Write(new string(dot, hornsLenght));
            Console.Write(new string(dot, leftRightDots));
            //center dots 
            Console.Write(star);
            Console.Write(new string(dot, middleDots));
            Console.Write(star);
            //right dots
            Console.Write(new string(dot, hornsLenght));
            Console.Write(new string(dot, leftRightDots));

            leftRightDots--;
            middleDots += 2;
            Console.WriteLine();
        }

        //botton part
        hornsLenght = X / 2;
        middleDots = width - 2 * (X / 2 + 1);
        middleDots -= 2;
        for (int rows = 1; rows < X - 1; rows++)
        {
            Console.Write(new string(dot, hornsLenght));
            Console.Write(new string(dot, rows));
            Console.Write(star);
            Console.Write(new string(dot, middleDots));
            Console.Write(star);
            Console.Write(new string(dot, rows));

            middleDots -= 2;


            Console.Write(new string(dot, hornsLenght));
            Console.WriteLine();

        }

        Console.Write(new string(dot, width / 2));
        Console.Write(star);
        Console.Write(new string(dot, width / 2));
        Console.WriteLine();


    }
}

