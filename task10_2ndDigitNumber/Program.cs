// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int SecondDigit(int num)
{
    int firstDigit = num / 100;
    return (num - firstDigit * 100) / 10;
}
int result = SecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");
}

else 
{
    Console.WriteLine("Введите правильное число");
}



// int number = Convert.to.Next(100, 1000);

// int SecondDigit(int num)
// {
//     int firstDigit = num / 100;
//     return (num - firstDigit * 100) / 10;
// }
// int result = SecondDigit(number);
// Console.WriteLine($"Итоговое число от {number} => {result}");