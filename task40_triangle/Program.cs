// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

System.Console.WriteLine("Число1");
int num1 = Convert.ToInt32(Console.ReadLine());;
System.Console.WriteLine("Число2");
int num2 = Convert.ToInt32(Console.ReadLine());;
System.Console.WriteLine("Число3");
int num3 = Convert.ToInt32(Console.ReadLine());;

if(CheckTriangle (num1, num2, num3)) System.Console.WriteLine("Cуществует");
else System.Console.WriteLine("Не Cуществует");



bool CheckTriangle(int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2);
    
}



