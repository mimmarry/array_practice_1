using System;
namespace array3;
class Programm
{
    static void Main(string[] args)
    {


        int[] array = { 4, 35, 12, 67, 37, 41 };
        
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result += array[i];
            }
        }
        Console.WriteLine("Сумма четных чисел массива равна " + result);


        Console.ReadLine();
    }
}