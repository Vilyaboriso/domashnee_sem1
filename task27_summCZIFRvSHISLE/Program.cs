// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

 
Очень долго пытался решить задачу, в итоге в 21 строке заменил i++ на i = i++ и только после этоого заработало.
Почему если оставить i++ то не все значения правильно считает?

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SumNumbers(number);
Console.WriteLine(Math.Abs(res));

int SumNumbers(int num)
{
    int sum = default;

    for (int i = 1; i <= Math.Abs(num); i = i++)
    {
        sum = sum + num % 10 + num /10 % 10 + num /100 % 10;
        num = num /1000;
    }
    
    return sum;
    
}

