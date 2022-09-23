// Задача 22: Напишите программу, которая                       
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



// Console.WriteLine("Введите число: ");                    // без метода и сравнения
// int number = Convert.ToInt32(Console.ReadLine());

// int n = number;
// int counter = 1;

// while (counter <= n)
// {
//     Console.WriteLine($"{counter, 2}    {counter*counter, 5}  ");
//     counter++;
// }



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;

void SquareTable(int n)
{
    int counter = 1;
    while (counter <= n)
    {
        Console.WriteLine($"{counter,3} ||   {counter * counter,5}||");
        counter++;
    }
}

if (n > 0) SquareTable(n);
else System.Console.WriteLine("Неверное значение");



