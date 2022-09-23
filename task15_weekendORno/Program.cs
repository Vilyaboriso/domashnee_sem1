// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру согласно дня недели");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num == 1) Console.WriteLine("Понедельник");
// else if(num == 2) Console.WriteLine("Вторник");
// else if(num == 3) Console.WriteLine("Среда");
// else if(num == 4) Console.WriteLine("Четверг");
// else if(num == 5) Console.WriteLine("Пятница");
// else if(num == 6) Console.WriteLine("Суббота");
// else if(num == 7) Console.WriteLine("Воскресенье");
// if(int num=6 || int = num7)
// else Console.WriteLine("Введите правильный номер");

Console.WriteLine("Введите цифру согласно дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 1) Console.WriteLine("Понедельник");
else if(num == 2) Console.Write("Вторник");
else if(num == 3) Console.Write("Среда");
else if(num == 4) Console.Write("Четверг");
else if(num == 5) Console.Write("Пятница");
else if(num == 6) Console.Write("Суббота");
else if(num == 7) Console.Write("Воскресенье");
else Console.WriteLine("Введите правильный номер");

bool Weekend (int num)
{
    return num == 6 || num == 7;
}
if (Weekend(num)) Console.Write(" - выходной");

bool Work (int num)
{
    return num == 1 || num == 2 || num == 3 || num == 4 || num == 5;
}

if (Work(num)) Console.WriteLine(" - рабочий день");



