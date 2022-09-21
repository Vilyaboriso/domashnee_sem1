// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Введите число");                        //первый вариант
// int number1 = Convert.ToInt32(Console.ReadLine()); 
// if(number1 % 7 == 0 && number1 % 23 == 0) Console.WriteLine("Кратно");
// else Console.WriteLine(" Не Кратно");


Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine()); 

bool IsAliquot7and23 (int num1)

{
    return num1 % 7 == 0 && num1 % 23 == 0;
}
if(IsAliquot7and23(number1)) Console.WriteLine("Кратно");
else Console.WriteLine(" Не Кратно");
