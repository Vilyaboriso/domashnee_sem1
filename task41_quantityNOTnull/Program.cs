// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

// Console.WriteLine("введите количество чисел");
//  int number = Convert.ToInt32(Console.ReadLine());


 

//  int[] CreateArrayRndInt (int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max+1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// int  GreaterThanZero(int[] array)
// {
//     int count = default;
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] > 0) count = count + 1;
// }
// return count;
// }


// int[] arr = CreateArrayRndInt (number, -100, 101);
// PrintArray(arr);

// int greaterThanZero = GreaterThanZero(arr);

// Console.WriteLine($"Количесвто чисел больше нуля = {greaterThanZero}");


Console.WriteLine("введите количество чисел");
 int number = Convert.ToInt32(Console.ReadLine());


 

 int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
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

int  GreaterThanZero(int[] array)
{
    int count = default;
for (int i = 0; i < array.Length; i++)
{
if (array[i] > 0) count = count + 1;
}
return count;
}


int[] arr = CreateArrayRndInt (number, -100, 101);
PrintArray(arr);

int greaterThanZero = GreaterThanZero(arr);

Console.WriteLine($"Количесвто чисел больше нуля = {greaterThanZero}");