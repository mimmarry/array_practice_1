
using System;
namespace array4;
class Programm
{
    static void Main(string[] args)
    {
        int[] array = { 4, 35, 12, 67, 37, 41 };

        int minValue = array[0];
        

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            { 
                minValue = array[i];    
            }
        }
        Console.WriteLine(minValue);


        Console.ReadLine();
    }
}