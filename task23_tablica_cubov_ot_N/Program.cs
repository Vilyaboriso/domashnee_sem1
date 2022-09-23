// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int n = number;

void SquareTable(int n)
{
    int counter = 1;
    while (counter <= n)
    {
        Console.WriteLine($"{counter,3} ||   {counter * counter * counter,5}||");
        counter++;
    }
}

if (n > 0) SquareTable(n);
else System.Console.WriteLine("Неверное значение");