// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Pow(2, 10);
// double num = Math.Sqrt(10); 
// // 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);


// Console.WriteLine("Введите координаты первой точки");                // Первый вариант без метода
// Console.Write("X1:  ");
// int x1 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("Y1:  ");
// int y1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("X2:  ");
// int x2 = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("Y2:  ");
// int y2 = Convert.ToInt32 (Console.ReadLine());

// double length = Math.Sqrt ((x2-x1)*(x2-x1) + (y2 - y1)*(y2-y1));

// double x = Math.Round(length, 2, MidpointRounding.ToZero);

// System.Console.WriteLine(x);



Console.WriteLine("Введите координаты первой точки");
Console.Write("X1:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("Y1:  ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки");
Console.Write("X2:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("Y2:  ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Length(int argX1, int argY1, int argX2, int argY2)
{
    double result = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2));
    return result;
}

double length = Length(x1, y1, x2, y2);

System.Console.WriteLine(Math.Round(length, 2, MidpointRounding.ToZero));


