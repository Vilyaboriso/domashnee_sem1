// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное сисло");
int number = Convert.ToInt32 (Console.ReadLine());

int firstDigit = number / 10000;
int secondtDigit = number / 1000 - firstDigit*10;
int thirdtDigit = number / 100 - firstDigit*100- secondtDigit*10;
int fifthDigit = number % 10;
int fourthDigit = (number - firstDigit*10000- secondtDigit*1000 -thirdtDigit*100- fifthDigit) / 10;

bool Palindrome (int num)
{
return firstDigit == fifthDigit && secondtDigit == fourthDigit;
}

if ((number < 100000 && number > 9999) || (number > -100000 && number < -9999))
{
if(Palindrome (number)) Console.WriteLine(" палиндром");
else Console.WriteLine(" не палиндром");
}
else Console.WriteLine("введите правильное число");
