using System;
namespace array_5;
class Programm
{
    static void Main()
    {

        Console.Write("Введите количество элементов в вашем массиве :");
        int elements = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[elements];  
       for(int i = 0; i < array.Length;i++)
        {
            Console.WriteLine($"\nВведите элемент массива под индексом {i}: \t");
            array[i] = Convert.ToInt32(Console.ReadLine()); 
        }
       Console.WriteLine("Наименьшее значение элемента из массива - " + array.Min());

        Console.ReadKey();
    }
        
}