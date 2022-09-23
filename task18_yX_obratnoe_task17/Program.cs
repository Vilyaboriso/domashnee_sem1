// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти от 1 до 4");   // Первый метод
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Quarter(quarter);
System.Console.WriteLine(result);


string Quarter (int quart)
{
    if(quart == 1) return "x > 0  y > 0";
    if(quart == 2) return "x < 0  y > 0";
    if(quart == 3) return "x < 0  y < 0";
    if(quart == 4) return "x > 0  y < 0";
    return "Введите корректное число";
}



// Console.WriteLine("Введите номер четверти от 1 до 4");          // метод с void, но он усложеннный, рабочий но тяжелый
// int quarter = Convert.ToInt32(Console.ReadLine());


// void Diapozon(int quart)
// {
//     if(quart == 1) Console.WriteLine("x > 0  y > 0");
//     else if(quart == 2) Console.WriteLine("x < 0  y > 0");
//     else if(quart == 3) Console.WriteLine("x < 0  y < 0");
//     else if(quart == 4) Console.WriteLine("x > 0  y < 0");
//     else Console.WriteLine("Введите корректное число");
// }

// Diapozon(quarter);