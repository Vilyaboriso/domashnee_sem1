// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixInt()
{
    Console.WriteLine("Кол-во. Строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Кол-во. Столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Макс число");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Мин число");
    int min = Convert.ToInt32(Console.ReadLine());

    int[,] newMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)  //rows (0)
    {
        for (int j = 0; j < columns; j++) //columns (1)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return newMatrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],  4}");
        }
Console.WriteLine("|");
    }

}

void ArithmeticMean(int[,] matrix)
{


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int x = matrix.GetLength(1);
        double arithmeticMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean = arithmeticMean + matrix[i, j];
        }
        arithmeticMean = arithmeticMean / x;
        System.Console.WriteLine($"{arithmeticMean}");
    }

}




int[,] array2D = CreateMatrixInt();
PrintMatrix(array2D);


ArithmeticMean(array2D);