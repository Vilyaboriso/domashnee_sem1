// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int x = number;
if (number > 99)
{
    if (x > 1000)
    {
        while (x > 1000)
        {
        x = x / 10;
        }
        int thirdDigit(int argx)
    {
        return x % 10;
    }
    int result = thirdDigit(number);
    Console.WriteLine($"Третья цифра от {number} => {result}");
    }
    
}

else Console.Write($"В числе {number} Третьей цифры нет");

