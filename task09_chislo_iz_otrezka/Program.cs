// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Слуайное число из отрезка 10 99 =>  {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit) Console.WriteLine($"Цифвры равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");




// int maxDigit = firstDigit;
// if (firstDigit < secondDigit) maxDigit = secondDigit;

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;




int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
int number = new Random().Next(10, 100);
int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");



// nt MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     // if (firstDigit > secondDigit) return firstDigit;
//     // return secondDigit;
//     if(IsEqualDigits(firstDigit, secondDigit)) return 0;
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }

// bool IsEqualDigits(int num1, int num2)
// {
//     return num1 == num2;
// }

// int number = new Random().Next(10, 100);
// int maxDigit = MaxDigit (number);

// string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
// Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigit}");
