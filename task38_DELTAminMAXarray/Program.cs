// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// array1[i] = rnd.NextDouble() * (max - min) + min;

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] MinMax(double[] array)
{
    double max = default;
    double min = default;

    for (int i = 0; i < array.Length; i = i + 2)
    {
        if (array[i] > array[i + 1])
        {
            max = array[i]; 
            min = array[i + 1];
        }
        else
        {
            max = array[i + 1];
            min = array[i];
        }
    }
    return new double[] { max, min };
}


double[] arr = CreateArrayRndInt(12, 1, 10);
PrintArray(arr);

double[] minMax = MinMax(arr);

Console.WriteLine($"Разница = {minMax[0] - minMax[1]}");
