using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int length = n / 2;
        int dotsLength = (n / 2) - 1;

        //------------------------------------------------------------
        for (int row = 0; row < length; row++)
        {
            for (int i = 0; i < dotsLength; i++)
            {
                Console.Write(".");
               
            }
            dotsLength--;
            Console.Write('/');
           
            Console.WriteLine();
        }

       
       
    }
}

 ////------------------------------------------------------------
 //       for (int row = 0; row < length; row++)
 //       {
 //           for (int i = 0; i < dotsLength+1; i++)
 //           {
 //               Console.Write(".");

 //           }
 //           dotsLength++;
 //           Console.Write('\\');
            
 //           Console.WriteLine();
 //       //------------------------------------------------------------
 //       }