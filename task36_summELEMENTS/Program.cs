﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random(); // var или Random тип данных с левой стороны

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] SummElementsOddIndex(int[] array)
{
    int summElements = default;
    for (int i = 1; i < array.Length; i = i +2)
    {
        summElements = summElements + array[i];
    }
    return new int[] {summElements};
}

int[] arr = CreateArrayRndInt(14, -10, 10);
PrintArray(arr);

int[] summElements = SummElementsOddIndex(arr);

Console.WriteLine($"количество чётных чисел в массиве = {summElements[0]}");