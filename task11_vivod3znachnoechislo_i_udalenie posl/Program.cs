// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);                   //Первый метод
// Console.WriteLine($"Случаное число равно {number}");
// int firstDigit = number/100;
// int thirdDigit = number % 10;
// Console.WriteLine($"{firstDigit}{thirdDigit}");

int number = new Random().Next(100, 1000);
int RemoveSecondDigit(int num1)
{
    int thirdDigit = num1 % 10;
    int firstDigit = num1 / 100;
    return firstDigit * 10 + thirdDigit;
}
int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");

