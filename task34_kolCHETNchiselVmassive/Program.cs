// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

int[] QuantityEvenNumbers(int[] array)
{
    int quantity = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) quantity = quantity + 1;
    }
    return new int[] {quantity};
}

int[] arr = CreateArrayRndInt(11, 100, 1000);
PrintArray(arr);

int[] quantity = QuantityEvenNumbers(arr);

Console.WriteLine($"количество чётных чисел в массиве = {quantity[0]}");