// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumResult = SumNumbers(number);
Console.WriteLine($"Сумма чисел о 1 до {number} = {sumResult}");

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}




// Console.WriteLine("Введите число:     ");
// int number = Convert.ToInt32(Console.ReadLine());
// int summResult = SummNumbers(number);
// System.Console.WriteLine($"{summResult}");

// int SummNumbers(int num)
// {
//     int summ = default;
//     for (int i = 1; i <= num; i++)
//     {
//         summ = summ + i;
//     }
//     return summ;
// }


// Console.WriteLine("Введите число:     ");                // второй вариант решения
// int number = Convert.ToInt32(Console.ReadLine());

// int SummNumbers2(int num)
// {
//     int summ = default;
//     int counter = 1;
//     while (counter <= num)
//     {
//         sunn = summ + counter;
//         counter ++;
//     }
//     return summ;
// }