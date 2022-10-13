using System;
namespace array;
class Programm
{
    static void Main(string[] args)
    {

        Console.Write("Введите количество элементов массива:\t");

        int elementscount = int.Parse(Console.ReadLine());

        int[] array = new int[elementscount];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\nВведите эелемент массива под индексом {i}:\t ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВывод элементoв массива ");

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
        Console.ReadLine();
    }
}