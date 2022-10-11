// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
  

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
         Console.WriteLine("|");
    }
}

int [,] array2D = CreateMatrixRndInt(3, 4, i, j);
PrintMatrix(array2D);


// int [,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
// PrintMatrix(array2D);
// System.Console.WriteLine();

// GetSquareEvenElem(array2D);
// PrintMatrix(array2D);
// // метод возведение чётных элементов массива в квадрат
// void GetSquareEvenElem(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)  //rows (0)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2) //columns (1)     Измененнный код
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }
