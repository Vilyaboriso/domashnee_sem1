// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int counter = 0;

if (number2 == 0)
    Console.WriteLine($"Возведение первого числа {number1} в натуральную степень второго числа {number2} = 1");

if (number2 > 0)
{
    double Degree(int num1, int num2)
    {
        double degree = num1 * num1;
        while (counter < num2)
        {
            degree = degree * num1;
            counter++;
        }
        return degree;
    }
    double degreeResult = Degree(number1, number1);
    Console.WriteLine($"Возведение первого числа {number1} в натуральную степень второго числа {number2} = {degreeResult}");
}

else Console.WriteLine("Введите второе число положительное");






