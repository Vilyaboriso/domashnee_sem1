// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = new int[5];
CreateFibonacciRow(array);
PrintArray(array);

void CreateFibonacciRow (int[] arr)
{
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
}
int[] CopyArray (int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] arr = CreateArrayRndInt (5, 1, 9);
int[] copyArray = CopyArray(arr);
copyArray[0] = 99;
PrintArray(arr);
PrintArray(copyArray);

