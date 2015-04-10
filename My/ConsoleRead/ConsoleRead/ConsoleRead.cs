using System;
using System.Text;
using System.Threading;
using System.Globalization;
class ConsoleRead
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        /*int i = Console.Read();
        Console.WriteLine(i);
        char ch = (char)i;
        Console.WriteLine(ch);
         

        for (int j = 0; j < 1000; j++)
        {

            Console.Write(j);
            System.Threading.Thread.Sleep(1);
            Console.Write("\r");
        }
        */

        //ConsoleKeyInfo key = Console.ReadKey();
        //Console.WriteLine("\nKey name: "+ key.Key);
        //Console.WriteLine("Key number: " + (int)key.Key);
        //Console.WriteLine("Special keys [{0}]", key.Modifiers);
        //Console.WriteLine("Character entered: "+ key.KeyChar);

        //Console.Write("Num: ");
        //string line = (Console.ReadLine());
        //int a = int.Parse(line);
        //Console.WriteLine(a);

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Въведете числ с десетична точка : ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Числото е {0}", a);
        string copyright = "\u00A9";
        Console.WriteLine(copyright);
    }
}

