// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите  номер строки: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  номер столбца: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(myMatrix);
Console.WriteLine();

// object x = myMatrix.GetValue(number1,number2);




if(FindNumber(myMatrix, number1, number2)) System.Console.WriteLine("Cуществует {как сюда вывести object ? } ");
else System.Console.WriteLine("Не Cуществует");




bool FindNumber(int[,] matrix, int num1, int num2)
{
return (number1 <= matrix.GetLength(0) && number2 <= matrix.GetLength(1));

}



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}



