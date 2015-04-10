using System;

class Array
{
    static void Main()
    {
        int[] arr = new int[5];
        int[] newArray = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter value for array {0} : ", arr[i] = i + 1);
            int value = Convert.ToInt32(Console.ReadLine());
            arr[i] = value;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            newArray[i] = arr[i];
            Console.Write("{0} ", newArray[i]);
        }

    }
   
    
}

